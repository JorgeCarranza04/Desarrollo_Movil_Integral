
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Cursos
{
	public class Utils
	{
		public static string ImageToByte(string path)
		{
			try
			{
				byte[] img = System.IO.File.ReadAllBytes(path);
				string base64String = Convert.ToBase64String(img);
				return base64String;

			}
			catch (Exception x)
			{
				throw new Exception(x.Message);
			}
		}
    }
}




