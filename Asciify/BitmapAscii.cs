using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Asciify
{
    class BitmapAscii
    {
         public Bitmap ogBitmap;
        public Bitmap greyBitmap;
        public int width =5000;
        public int heigth = 5000;
        public double [,] grayScaleArray;


        public  void load_OG_Bitmap(string filename)   {

            ogBitmap = new Bitmap(filename);          
   
        }
       public string Ascitize (Bitmap bmpTemp, int kernalWidth, int kernalHeight)
        {
            string finalAscii = "";
            List<Color > kernelPixels = new List<Color>();
            double kernelAverage ;
            string asciiCharacter;
            for(int y = 0 ; y<bmpTemp.Height; y+= kernalHeight)
            {
                for(int x =0; x<bmpTemp.Width; x+= kernalWidth)
                {
                    //  GET PIXEL'S COLOR for "1x1" kernal
                    Color pixelColor = bmpTemp.GetPixel(x,y);

                    //ADD KERNEL PIXEL(S) TO LIST
                    kernelPixels.Add(pixelColor);

                    //SEND OUR LIST TO AVERAGE COLOR
                    kernelAverage = AverageColor(kernelPixels);

                    //SEND KERNEL AVG TO GRAYTOSTRING METHOD 
                    asciiCharacter = GrayToString(kernelAverage);

                    //FLUSH LIST
                    kernelPixels.Clear();

                    //ADD TO FINAL STRING
                    finalAscii += asciiCharacter;

                }//end for
                finalAscii +="\r\n";
            }//end for

            return finalAscii;
        }

        double AverageColor(List<Color>pixelColors)
        {
            double normalizedKernelValue = 0;
           for (int x = 0; x<pixelColors.Count; x++)
            {
              normalizedKernelValue= normalizedKernelValue + ((AveragePixel(pixelColors[x]) /255));
               
            }
           return normalizedKernelValue;
        }
           

          double AveragePixel(Color tempGrayscaleColor)
            {
                
                return (((.21*tempGrayscaleColor.R) + (.72 * tempGrayscaleColor.G) + (.07 * tempGrayscaleColor.B)));
           
            }

        string GrayToString(double tempNormalizedKernelValue)
        {
            string tempAsciiString = "";
            if(tempNormalizedKernelValue > .85)
            {
                tempAsciiString = " ";
            }else if(tempNormalizedKernelValue < .85 && tempNormalizedKernelValue > .7)
            {
                tempAsciiString = ".";
            }else if(tempNormalizedKernelValue < .7 && tempNormalizedKernelValue > .55)
            {
                tempAsciiString = "^";
            }else if(tempNormalizedKernelValue < .55 && tempNormalizedKernelValue > .3)
            {
                tempAsciiString = "*";
            }else if(tempNormalizedKernelValue < .3 && tempNormalizedKernelValue > .15)
            {
                tempAsciiString = "#";
            }else 
            {
                tempAsciiString= "@";
            }
            return tempAsciiString;

        }

        public void load_OG_Grey(string filename)
        {
            Bitmap tempGreyBitmap = new Bitmap(filename);
            width = tempGreyBitmap.Width;
            heigth = tempGreyBitmap.Height;

            for (int x = 0; x<tempGreyBitmap.Width; x++)
            {
                for(int y = 0; y<tempGreyBitmap.Height; y++)
                {
                      Color pixelColor = tempGreyBitmap.GetPixel(x,y);
                      byte luminosity = (byte)(((.21*pixelColor.R) + (.72 * pixelColor.G) + (.07 * pixelColor.B)));
                      Color grayScale = Color.FromArgb(luminosity,luminosity,luminosity);
                      tempGreyBitmap.SetPixel(x,y,grayScale);

            
                }
            }
            greyBitmap = tempGreyBitmap;

            grayScaleArray = new double[width,heigth];
        }



 

    }
}
