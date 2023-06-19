using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto_DA.Modelos
{
	public class Cliente: Pessoa
    {
        public int Id { get; set; }
        public int NumFiscal { get; set; }

        public List<Bilhete> Bilhetes { get; set; }

		public string ObterInformacoesBilhetes(out int numBilhetes, out float valorBilhetes)
		{
			string nomeFicheiro = $"{Nome}_{NumFiscal}.txt";
			string informacoes = "";
			numBilhetes = 0;
			valorBilhetes = 0f;

			if (File.Exists(nomeFicheiro))
			{
				using (StreamReader sr = new StreamReader(nomeFicheiro))
				{
					string line;
					while ((line = sr.ReadLine()) != null)
					{
						if (line.StartsWith("Nº de Bilhetes:"))
						{
							string[] parts = line.Split(':');
							if (parts.Length == 2)
							{
								if (int.TryParse(parts[1].Trim(), out int parsedNumBilhetes))
								{
									numBilhetes = parsedNumBilhetes;
									informacoes += $"{numBilhetes}\n";
								}
								else
								{
									informacoes += "Erro ao converter Nº de Bilhetes.\n";
								}
							}
						}
						else if (line.StartsWith("Valor Bilhetes Adquiridos:"))
						{
							string[] parts = line.Split(':');
							if (parts.Length == 2)
							{
								if (float.TryParse(parts[1].Trim().TrimEnd('€'), out float parsedValorBilhetes))
								{
									valorBilhetes = parsedValorBilhetes;
									informacoes += $"{valorBilhetes}€\n";
								}
								else
								{
									informacoes += "Erro ao converter Valor Bilhetes Adquiridos.\n";
								}
							}
						}
					}
				}
			}

			return informacoes;
		}

		public override string ToString()
		{
			int numBilhetes;
			float valorBilhetes;
			ObterInformacoesBilhetes(out numBilhetes, out valorBilhetes);
			string informacoesCliente = $"Cliente {Id}: {base.Nome}, {base.Morada}, {NumFiscal}";
			return $"{informacoesCliente}\n - Bilhetes: {numBilhetes}, {valorBilhetes}€";
		}
	}
}
