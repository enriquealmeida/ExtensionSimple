using System;
using System.Runtime.InteropServices;
using Artech.Architecture.Common.Services;
using Artech.Architecture.UI.Framework.Packages;
using Artech.Common.Properties;

namespace GUG.Packages.ExtensionSimple
{
    [Guid("0290bda2-2969-47b4-948a-5a0bb880b85f")]

    enum Tool { Phabricator, GitHub};

    public class Package : AbstractPackageUI {
        public static Guid guid = typeof(Package).GUID;

      public override string Name
      {
         get { return "ExtensionSimple"; }
      }

      public override void Initialize(IGxServiceProvider services)
      {
         base.Initialize(services);
            AddCommandTarget(new CommandManager());
        }

        

      
    }
}
