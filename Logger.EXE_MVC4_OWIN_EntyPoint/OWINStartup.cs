using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logger.EXE_MVC4_OWIN_EntyPoint 
{
	public partial class OWINStartup
	{
		// Invoked once at startup to configure your application.
		public void Configuration(Owin.IAppBuilder builder)
		{
			// OWIN module: Logger.DLL_OWIN
			builder.Use(typeof(Logger.OWIN.TestLogger));

			return;
		}
		
	}
}
