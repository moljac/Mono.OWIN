using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logger.OWIN 
{
	using System;
	using System.Collections.Generic;
	using System.Threading.Tasks;
	using AppFunc = Func<IDictionary<string, object>, System.Threading.Tasks.Task>;

	public class TestLogger
	{
		private readonly AppFunc _next;
		public TestLogger(AppFunc next)
		{
			if (next == null)
			{
				throw new ArgumentNullException("next");
			}
			_next = next;
		}
		public Task Invoke(IDictionary<string, object> environment)
		{
			string msg = string.Format
							(
							  "Hitting TestLogger, path: {0}"
							, environment["owin.RequestPath"]
							);
			System.Diagnostics.Trace.WriteLine(msg);
			return _next(environment);
		}
	}
}
