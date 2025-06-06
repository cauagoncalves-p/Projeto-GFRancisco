string nome = "00000000000";
//012345678910
string novo = nome.Substring(0, 3) + "." + nome.Substring(3,3) + "." + nome.Substring(6,3) + "-" + nome.Substring(9,2);
Console.WriteLine(novo);