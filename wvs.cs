            char[] qwwe = "CDEFABGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            foreach (char sa in qwwe)
            {
                string qwde = sa + ":\\";
                if (System.IO.Directory.Exists(qwde) == true)
                {
                    System.Console.WriteLine(qwde);
                }
            }
