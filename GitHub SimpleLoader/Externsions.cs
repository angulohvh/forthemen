using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleLoader.Extensions
{
    class Externsions
    {
        public class Vector3 //wtf coding, i am listerningngnn to the music yes
        {
            public float x, y, z;
            public Vector3(float x2, float y2, float z2)
            {
                this.x = x2;
                this.y = y2;
                this.z = z2;
            }

            public override string ToString() => $"{Math.Round(x, 2)}, {Math.Round(y, 2)}, {Math.Round(z, 2)}"; //wtf
            public Color to_rgb()
            {
                double h = this.x;
                double sl = this.y;
                double l = this.z;

                if (h < 0f)
                    h = 1f - -h;
                else if (h > 1f)
                    h = -(-h + 1f);

                double v = (l <= 0.5) ? (l * (1.0 + sl)) : (l + sl - l * sl), r = l, g = l, b = l;

                if (v > 0)
                {
                    int sextant;
                    double m, sv, fract, vsf, mid1, mid2;

                    m = l + l - v;
                    sv = (v - m) / v;
                    h *= 6.0;
                    sextant = (int)h;
                    fract = h - sextant;
                    vsf = v * sv * fract;
                    mid1 = m + vsf;
                    mid2 = v - vsf;
                    switch (sextant)
                    {
                        case 0:
                            r = v;
                            g = mid1;
                            b = m;
                            break;
                        case 1:
                            r = mid2;
                            g = v;
                            b = m;
                            break;
                        case 2:
                            r = m;
                            g = v;
                            b = mid1;
                            break;
                        case 3:
                            r = m;
                            g = mid2;
                            b = v;
                            break;
                        case 4:
                            r = mid1;
                            g = m;
                            b = v;
                            break;
                        case 5:
                            r = v;
                            g = m;
                            b = mid2;
                            break;
                    }
                }

                return Color.FromArgb(Convert.ToByte(r * 255.0f), Convert.ToByte(g * 255.0f), Convert.ToByte(b * 255.0f));
            }
        }

        public static class Rainbow
        {
            const float speed = 0.005f;
            const float speed_other = speed * 20f;
            static bool mode1 = false, mode2 = false;
            static Vector3 hsl = new Vector3(0f, 0.5f, 0.5f);


            public static void change_color(params Control[] controls)
            {
                hsl.x += speed;
                if (hsl.x > 1f)
                {
                    hsl.x = 0f;
                    hsl.y += mode1 ? -speed_other : speed_other;
                }

                if (hsl.y > 1f || hsl.y < 0.4f)
                {
                    if (hsl.y > 1f)
                    {
                        mode1 = true;
                        hsl.y -= speed_other;
                    }
                    else
                    {
                        mode1 = false;
                        hsl.y += speed_other;
                    }
                    hsl.z += mode2 ? -speed_other : speed_other;

                }

                if (hsl.z > 0.7f || hsl.z < 0.3f)
                {
                    if (hsl.z > 0.7f)
                    {
                        mode2 = true;
                        hsl.z -= speed_other;
                    }
                    else
                    {
                        mode2 = false;
                        hsl.z += speed_other;
                    }
                }

                var cl = hsl.to_rgb();
                foreach (Control c in controls)
                {
                    if (c is Panel)
                    {
                        c.BackColor = cl;
                    }
                    else
                    {
                        c.ForeColor = cl;
                    }
                }

            }
        }
    }
}
