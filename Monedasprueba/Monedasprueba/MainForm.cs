/*
 * Created by SharpDevelop.
 * User: USUARIO
 * Date: 21/09/2022
 * Time: 03:50 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Monedasprueba
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
	
	
		private int n1;
		private int n2;
		private int result;
		private string resultado;
		private int c100;
        private int x;		
        private int c20;
        private int c1;
        private int c5;
        private int c10;
        private int c2;
        private string mostrar1;
        private string mostrar2;
        private string mostrar3;
        private string mostrar4;
        
        
		public MainForm()
		{
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			
			//
			InitializeComponent();
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
		
			
			this.n1 = Convert.ToInt32(textBox1.Text);
			
	}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.result= n1 / n2; 
			this.resultado= Convert.ToString(this.result);
			textBox3.Text= this.resultado;
			
		}
		void TextBox3TextChanged(object sender, EventArgs e)
		{
			
			
		}
		
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
         
			this.n2 = Convert.ToInt32(textBox2.Text);
			
		}
		
		
		
		
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Text= "0" ; 
			textBox2.Text= "0" ;
			textBox3.Text="0";
			textBox4.Text="0";
			textBox5.Text="0";
			textBox6.Text="0";
			textBox7.Text="0";
			textBox8.Text="0";
			textBox9.Text="0";
			textBox10.Text="0";
		}
		
		
		
		
		
		
		void TextBox4TextChanged(object sender, EventArgs e)
		{
			
		}
		
		
		void TextBox5TextChanged(object sender, EventArgs e)
		{
			
		}
		
		
		void TextBox6TextChanged(object sender, EventArgs e)
		{
			
		}
		
		
		void TextBox7TextChanged(object sender, EventArgs e)
		{
			
		}
		
		
		void TextBox8TextChanged(object sender, EventArgs e)
		{
			
		}
		
		
		void TextBox9TextChanged(object sender, EventArgs e)
		{
			
		}
		void Button3Click(object sender, System.EventArgs e)
		{
        	if(comboBox1.Text=="Dólar"){
			
			this.x= Convert.ToInt32(this.resultado);
				
			while(x>=100){
            x=x-100;
            c100++;
            }
			this.mostrar1 =Convert.ToString(this.c100);
			textBox4.Text= this.mostrar1;
			
            while(x>=20){
            x=x-20;
            c20++;
            }
			this.mostrar2 =Convert.ToString(this.c20);
			textBox6.Text= this.mostrar2;
            while(x>=5){
            x=x-5;
            c5++;
             }
            this.mostrar3 =Convert.ToString(this.c5);
			textBox9.Text= this.mostrar3;
            while(x>=1){
            x=x-1;
            c1++;
            }
           this.mostrar4 =Convert.ToString(this.c1);
			textBox8.Text= this.mostrar4;
			}
			if(comboBox1.Text=="Euro"){
			
			this.x= Convert.ToInt32(this.resultado);
				
			while(x>=100){
            x=x-100;
            c100++;
            }
			this.mostrar1 =Convert.ToString(this.c100);
			textBox4.Text= this.mostrar1;
			
            while(x>=10){
            x=x-10;
            c10++;
            }
			this.mostrar2 =Convert.ToString(this.c10);
			textBox7.Text= this.mostrar2;
            while(x>=5){
            x=x-5;
            c5++;
             }
            this.mostrar3 =Convert.ToString(this.c5);
			textBox9.Text= this.mostrar3;
            while(x>=1){
            x=x-1;
            c1++;
            }
           this.mostrar4 =Convert.ToString(this.c1);
			textBox8.Text= this.mostrar4;
			}
		
         
			if(comboBox1.Text=="PesoMx"){
			
			this.x= Convert.ToInt32(this.resultado);
				
			while(x>=100){
            x=x-100;
            c100++;
            }
			this.mostrar1 =Convert.ToString(this.c100);
			textBox4.Text= this.mostrar1;
			
            while(x>=20){
            x=x-20;
            c20++;
            }
			this.mostrar2 =Convert.ToString(this.c20);
			textBox6.Text= this.mostrar2;
            while(x>=5){
            x=x-5;
            c5++;
             }
            this.mostrar3 =Convert.ToString(this.c5);
			textBox9.Text= this.mostrar3;
            while(x>=1){
            x=x-1;
            c1++;
            }
           this.mostrar4 =Convert.ToString(this.c1);
			textBox8.Text= this.mostrar4;
			}
			if(comboBox1.Text=="PesoCh"){
			
			this.x= Convert.ToInt32(this.resultado);
				
			while(x>=100){
            x=x-100;
            c100++;
            }
			this.mostrar1 =Convert.ToString(this.c100);
			textBox4.Text= this.mostrar1;
			
            while(x>=10){
            x=x-10;
            c10++;
            }
			this.mostrar2 =Convert.ToString(this.c10);
			textBox7.Text= this.mostrar2;
            while(x>=2){
            x=x-2;
            c2++;
             }
            this.mostrar3 =Convert.ToString(this.c2);
			textBox10.Text= this.mostrar3;
            while(x>=1){
            x=x-1;
            c1++;
            }
           this.mostrar4 =Convert.ToString(this.c1);
			textBox8.Text= this.mostrar4;
			}
			if(comboBox1.Text=="Real"){
			
			this.x= Convert.ToInt32(this.resultado);
				
			while(x>=100){
            x=x-100;
            c100++;
            }
			this.mostrar1 =Convert.ToString(this.c100);
			textBox4.Text= this.mostrar1;
			
            while(x>=10){
            x=x-10;
            c10++;
            }
			this.mostrar2 =Convert.ToString(this.c10);
			textBox7.Text= this.mostrar2;
            while(x>=5){
            x=x-5;
            c5++;
             }
            this.mostrar3 =Convert.ToString(this.c5);
			textBox9.Text= this.mostrar3;
            while(x>=1){
            x=x-1;
            c1++;
            }
           this.mostrar4 =Convert.ToString(this.c1);
			textBox8.Text= this.mostrar4;
			}
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
	}
		
	}