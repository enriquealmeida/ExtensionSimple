using Artech.Architecture.UI.Framework.Helper;
using Artech.Architecture.UI.Framework.Services;
using Artech.Common.Framework.Commands;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace GUG.Packages.ExtensionSimple
{
    class CommandManager : CommandDelegator
	{
		public CommandManager()
		{
          
            AddCommand(CommandKeys.AboutExtensionSimple, new ExecHandler(ExecAboutExtensionSimple), new QueryHandler(EnableAlways));

		}

		public bool ExecAboutExtensionSimple(CommandData cmdData)
		{
			Assembly assem = this.GetType().Assembly;
			object[] atributos = assem.GetCustomAttributes(typeof(AssemblyVersionAttribute), false);
			using (Form aboutBox = new AboutExtensionSimple())
			{
				aboutBox.ShowDialog();
			}
			return true;
		}




 



		private bool EnableAlways(CommandData cmdData, ref CommandStatus status)
		{
			status.State = CommandState.Enabled;
			return true;
		}
	}
}
