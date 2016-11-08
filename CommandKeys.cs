using System;
using System.Collections.Generic;
using System.Text;
using Artech.Common.Framework.Commands;

namespace GUG.Packages.ExtensionSimple
{
    static class CommandKeys
    {
        
        // Acerca de
        private static CommandKey aboutExtensionSimple = new CommandKey(Package.guid, "AboutExtensionSimple");
        public static CommandKey AboutExtensionSimple { get { return aboutExtensionSimple; } }


    }
}
