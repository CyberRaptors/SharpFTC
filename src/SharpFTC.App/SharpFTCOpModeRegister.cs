using Com.Qualcomm.Robotcore.Eventloop.OpModes;
using Java.Interop;
using SharpFTC.Core.Attributes;
using SharpFTC.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpFTC.App
{
    public class SharpFTCOpModeRegister
    {
        const string SearchExternalOpModeAssembliesConfigPropertyName = "UseExternalAssemblies";

        [Export("registerSharpFTCOpModes")]
        public static void RegisterSharpFTCOpModes(nint opModeManager)
        {
            var configClass = GetConfigClass();

            var searchAssemblies = GetSearchAssemblies(configClass);

            foreach (var asm in searchAssemblies)
            {
                foreach (var type in asm.GetTypes())
                {
                    if (type.GetCustomAttribute<TeleOpAttribute>() is TeleOpAttribute teleOpAttr) RegisterOpMode(teleOpAttr.Name!, teleOpAttr.Group!, false);
                    else if (type.GetCustomAttribute<AutonomousAttribute>() is AutonomousAttribute autonAttr) RegisterOpMode(autonAttr.Name!, autonAttr.Group!, true);
                }
            }
        }

        static void RegisterOpMode(string name, string group, bool autonomous)
        {

        }

        static Type GetConfigClass()
        {
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                var name = assembly.GetName().Name;

                if (name == "SharpFTC.App" || name == "SharpFTC.Core" || name == "SharpFTC.AndroidBindings") continue;


                var configClass = assembly.GetTypes().FirstOrDefault(t => t.GetCustomAttribute<SharpFTCConfigAttribute>() is not null);

                if (configClass is not null)  return configClass;
            }

            throw new SharpFTCInternalException("Could not find SharpFTCConfig configuration class");
        }

        static IEnumerable<Assembly> GetSearchAssemblies(Type configClass)
        {
            var searchAsmNames = (IEnumerable<string>) configClass.GetField(SearchExternalOpModeAssembliesConfigPropertyName, BindingFlags.Static | BindingFlags.Public)!.GetValue(null)!;

            return AppDomain.CurrentDomain.GetAssemblies().Where(asm => searchAsmNames.Contains(asm.GetName().Name)).Append(configClass.Assembly);
        }
    }
}
