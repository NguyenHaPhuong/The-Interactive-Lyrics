using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InteractiveLyrics
{
	public partial class InteractiveLyric : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			{

				LtlDate.Text = String.Format("{0:D}", DateTime.Now);
				if (DateTime.Now.Hour < 12)
				{
					LtlGreeting.Text = "Good Morning";
				}
				else if (DateTime.Now.Hour < 18)
				{
					LtlGreeting.Text = "Good Afternoon";
				}
				else
				{
					LtlGreeting.Text = "Good Evening";
				}
			}
		}


		
		protected void btnGenerate_Click(object sender, EventArgs e)
		{
			string textcolor = "blue";

			if (RbGreen.Checked)
			{
				textcolor = "green";
			}
			else if (RbOrange.Checked)
			{
				textcolor = "orange";
			}


			string[] animals = TxtAnimals.Text.Split(',');
			string[] sounds = TxtSounds.Text.Split(',');


			string stanza = @"Old MacDonald had a farm, E-I-E-I-O <br>
								And on his farm he had a {0}, E-I-E-I-O<br>
								With a {1}-{1} here and a {1}-{1} there<br>
								Here a {1}, there a {1}<br>
								Everywhere a {1}-{1}<br>
								Old MacDonald had a farm, E-I-E-I-O <br><br>";


			string lyrics = String.Format("<hr/><div class='stanza_{0}'>", textcolor);

			for (int i = 0; i < animals.Length; i++)
			{
				string animal = animals[i].Trim().ToUpper();
				string sound = sounds[i].Trim().ToUpper();

				lyrics += String.Format(stanza, animal, sound);

			}
			ltlLyrics.Text = lyrics + " </div>";
		}
	}

	
}
	
