using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;


namespace AppPDI.Models
{
    public class PictureToEdit
    {

        public PictureToEdit()
        {

        }


        public DataTable CalcularHistograma(Bitmap origem)
        {
            Color pixel;

            IDictionary<int, int> histograma = new Dictionary<int, int>();
            DataTable dt = new DataTable();


            for (int x = 0; x < origem.Width; x++)
            {
                for (int y = 0; y < origem.Height; y++)
                {
                    pixel = origem.GetPixel(x, y);

                    int valorIntensidade = (int)( (double) pixel.R + pixel.G + pixel.B / 3 );

                    if (histograma.ContainsKey(valorIntensidade))
                    {
                        histograma[valorIntensidade]++;
                    }
                    else
                    {
                        histograma.Add(valorIntensidade, 1);
                    }

                }
            }

            dt.Columns.Add("Intensidade", typeof(int));
            dt.Columns.Add("Ocorrencias", typeof(int));

            foreach (var pair in histograma)
            {
                DataRow dr = dt.NewRow();
                dr["Intensidade"] = pair.Key;
                dr["Ocorrencias"] = pair.Value;
                dt.Rows.Add(dr);
            }

            return dt;
        }

        public Bitmap ApplyLightnessFilter(Bitmap origemImage)
        {
            try
            {
                Bitmap destino = new Bitmap(origemImage.Width, origemImage.Height);

                Color pixel;

                int valueToPass = origemImage.Width * origemImage.Height;

                for (int x = 0; x < origemImage.Width; x++)
                {
                    for (int y = 0; y < origemImage.Height; y++)
                    {
                        pixel = origemImage.GetPixel(x, y);
                        int color = CalculateLightnessFilter(pixel);
                        destino.SetPixel(x, y, Color.FromArgb(color, color, color));
                    }
                }

                return destino;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível aplicar o filtro Lightness");
            }
        }

        private int CalculateLightnessFilter(Color pixel)
        {
            int valueToReturn;

            int maxValue = Math.Max(pixel.R, pixel.G);
            maxValue = Math.Max(maxValue, pixel.B);

            int minValue = Math.Min(pixel.R, pixel.G);
            minValue = Math.Min(minValue, pixel.B);

            valueToReturn = (maxValue + minValue) / 2;

            return valueToReturn;
        }


        public Bitmap ApplyAVGFilter(Bitmap origemImage)
        {
            try
            {
                Bitmap destino = new Bitmap(origemImage.Width, origemImage.Height);

                Color pixel;

                int valueToPass = origemImage.Width * origemImage.Height;

                for (int x = 0; x < origemImage.Width; x++)
                {
                    for (int y = 0; y < origemImage.Height; y++)
                    {
                        pixel = origemImage.GetPixel(x, y);
                        int color = (pixel.R + pixel.G + pixel.B) / 3;
                        destino.SetPixel(x, y, Color.FromArgb(color, color, color));
                    }
                }

                return destino;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível aplicar o filtro AVG");
            }
        }


        public Bitmap ApplyLuminosityFilter(Bitmap origemImage)
        {
            try
            {
                Bitmap destino = new Bitmap(origemImage.Width, origemImage.Height);

                Color pixel;

                int valueToPass = origemImage.Width * origemImage.Height;

                for (int x = 0; x < origemImage.Width; x++)
                {
                    for (int y = 0; y < origemImage.Height; y++)
                    {
                        pixel = origemImage.GetPixel(x, y);
                        int color = (int)(0.21 * pixel.R + 0.72 * pixel.G + 0.07 * pixel.B);
                        destino.SetPixel(x, y, Color.FromArgb(color, color, color));
                    }
                }

                return destino;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível aplicar o filtro AVG");
            }
        }

        public Bitmap ApplyNegativeOfImage(Bitmap origemImage)
        {
            Bitmap destino = new Bitmap(origemImage.Width, origemImage.Height);

            Color pixelOrigem;

            for (int x = 0; x < origemImage.Width; x++)
            {
                for (int y = 0; y < origemImage.Height; y++)
                {
                    pixelOrigem = origemImage.GetPixel(x, y);
                    destino.SetPixel(x, y, Color.FromArgb(255 - pixelOrigem.R, 255 - pixelOrigem.G, 255 - pixelOrigem.B));
                }
            }

            return destino;
        }

        public Bitmap ApplyThresholdInImagem(Bitmap origemImage)
        {
            Bitmap destino = new Bitmap(origemImage.Width, origemImage.Height);

            // Colocar controle de nível na própria aplicação
            int limiar = 120;

            Color pixelOrigem;

            for (int x = 0; x < origemImage.Width; x++)
            {
                for (int y = 0; y < origemImage.Height; y++)
                {
                    pixelOrigem = origemImage.GetPixel(x, y);

                    double media = (double)(pixelOrigem.R + pixelOrigem.G + pixelOrigem.B) / 3;

                    int white = 255;
                    int black = 0;

                    if (media < limiar)
                    {
                        destino.SetPixel(x, y, Color.FromArgb(black, black, black));
                    }
                    else
                    {
                        destino.SetPixel(x, y, Color.FromArgb(white, white, white));
                    }

                }
            }

            return destino;
        }


        public Bitmap ApplyLogTransformation(Bitmap origemImage)
        {
            Bitmap destino = new Bitmap(origemImage.Width, origemImage.Height);

            Color pixelOrigem;

            for (int x = 0; x < origemImage.Width; x++)
            {
                for (int y = 0; y < origemImage.Height; y++)
                {
                    pixelOrigem = origemImage.GetPixel(x, y);

                    int color = (int)((255 / Math.Log(256)) * Math.Log(1 + pixelOrigem.R));

                    destino.SetPixel(x, y, Color.FromArgb(color, color, color));
                }
            }

            return destino;
        }


        public Bitmap ApplyExpTransformation(Bitmap origemImage)
        {
            Bitmap destino = new Bitmap(origemImage.Width, origemImage.Height);

            Color pixelOrigem;

            for (int x = 0; x < origemImage.Width; x++)
            {
                for (int y = 0; y < origemImage.Height; y++)
                {
                    pixelOrigem = origemImage.GetPixel(x, y);

                    int media = (pixelOrigem.R + pixelOrigem.G + pixelOrigem.B) / 3;

                    int color = (int)(0.01 * media * media);

                    if (color > 255)
                    {
                        color = 255;
                    }

                    destino.SetPixel(x, y, Color.FromArgb(color, color, color));
                }
            }
            return destino;
        }

        public Bitmap ApplySqrtTransformation(Bitmap origemImage)
        {
            Bitmap destino = new Bitmap(origemImage.Width, origemImage.Height);

            Color pixelOrigem;

            for (int x = 0; x < origemImage.Width; x++)
            {
                for (int y = 0; y < origemImage.Height; y++)
                {
                    pixelOrigem = origemImage.GetPixel(x, y);

                    int color = color = (int)(10 * Math.Sqrt(pixelOrigem.R));

                    destino.SetPixel(x, y, Color.FromArgb(color, color, color));
                }
            }

            return destino;
        }
    }
}
