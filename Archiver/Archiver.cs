using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archiver
{
    class Archiver
    {
        public static void Compress(string sourceFile, string compressedFile)
        {
            FileStream originalFile = null;
            FileStream archive = null;

            try
            {
                if (compressedFile[compressedFile.Length - 1] != '\\')
                {
                    compressedFile += '\\';
                }
                
                string[] massiv = sourceFile.Split('\\');
                string filename = massiv[massiv.Length - 1];
                string name = filename.Substring(0, filename.LastIndexOf('.'));
                string pyt = compressedFile + filename.Substring(0, filename.LastIndexOf('.')) + ".arc";

                if (File.Exists(pyt))
                {
                    File.Delete(pyt);
                }

                string Format = sourceFile.Substring(sourceFile.LastIndexOf('.') + 1);
                originalFile = new FileStream(sourceFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                archive = new FileStream(pyt, FileMode.CreateNew);

                archive.WriteByte((byte)Format.Length);
                for (int i = 0; i < Format.Length; ++i)
                {
                    archive.WriteByte((byte)Format[i]);
                }

                List<byte> Bt = new List<byte>();
                
                while (originalFile.Position < originalFile.Length)
                {
                    byte B = (byte)originalFile.ReadByte();
                    
                    if (Bt.Count == 0)
                    {
                        Bt.Add(B);
                    }

                    else if (Bt[Bt.Count - 1] != B)
                    {
                        Bt.Add(B);
                        if (Bt.Count == 255)
                        {
                            archive.WriteByte((byte)0);
                            archive.WriteByte((byte)255);
                            archive.Write(Bt.ToArray(), 0, 255);
                            Bt.Clear();
                        }
                    }
                    else
                    {
                        if (Bt.Count != 1)
                        {
                            archive.WriteByte((byte)0);
                            archive.WriteByte((byte)(Bt.Count - 1));
                            archive.Write(Bt.ToArray(), 0, Bt.Count - 1);
                            Bt.RemoveRange(0, Bt.Count - 1);
                        }
                        
                        Bt.Add(B);
                        
                        while ((B = (byte)originalFile.ReadByte()) == Bt[0])
                        {
                            Bt.Add(B);
                            if (Bt.Count == 255)
                            {
                                archive.WriteByte((byte)255);
                                archive.WriteByte(Bt[0]);
                                Bt.Clear();
                                break;
                            }
                        }
                        
                        if (Bt.Count > 0)
                        {
                            archive.WriteByte((byte)Bt.Count);
                            archive.WriteByte(Bt[0]);
                            Bt.Clear();
                            Bt.Add(B);
                        }
                    }
                }
                if (Bt.Count > 0)
                {
                    archive.WriteByte((byte)0);
                    archive.WriteByte((byte)Bt.Count);
                    archive.Write(Bt.ToArray(), 0, Bt.Count);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (originalFile != null) originalFile.Close();
                if (archive != null) archive.Close();
            }
        }

        public static void DeCompress(string compressedFile, string targetFile)
        {
            if (!File.Exists(compressedFile))
            {
                return;
            }

            FileStream archive = null;
            FileStream newfile = null;

            try
            {
                if (targetFile[targetFile.Length - 1] != '\\')
                {
                    targetFile += '\\';
                }

                string[] massiv = compressedFile.Split('\\');
                string filename = massiv[massiv.Length - 1];
                string name = targetFile + filename.Substring(0, filename.LastIndexOf('.'));
                string format = ".";

                archive = new FileStream(compressedFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                int FormatLen = archive.ReadByte();
                
                for (int i = 0; i < FormatLen; ++i)
                {
                    format += (char)archive.ReadByte();
                }
                    
                if (File.Exists(name + format))
                {
                    File.Delete(name + format);
                }
                    
                newfile = new FileStream(name + format, FileMode.CreateNew);
                
                while (archive.Position < archive.Length)
                {
                    int Bt = archive.ReadByte();
                    if (Bt == 0)
                    {
                        Bt = archive.ReadByte();
                        for (int j = 0; j < Bt; ++j)
                        {
                            byte b = (byte)archive.ReadByte();
                            newfile.WriteByte(b);
                        }
                    }
                    else
                    {
                        int Value = archive.ReadByte();
                        for (int j = 0; j < Bt; ++j)
                        {
                            newfile.WriteByte((byte)Value);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (archive != null)
                {
                    archive.Close();
                }

                if (newfile != null)
                {
                    newfile.Close();
                }
            }
        }
    }
}
