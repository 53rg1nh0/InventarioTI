using iTextSharp.text;
using iTextSharp.text.pdf;
using Image = iTextSharp.text.Image;
using Font = iTextSharp.text.Font;
using InventarioTI.Entites.emuns;
using InventarioTI.Entites.Exceptions;

namespace InventarioTI.Services
{
    internal class Termo
    {
        private static string _path;


        public static void PDF(List<Inventario> list, string acessorios, bool headset = false)
        {
            try
            {
                string caminho = "";
                _path = Properties.Settings.Default.Path + @"\Termos";

                caminho = Properties.Settings.Default.Path + @"\Termos\"/*@"C:\Users\sesousa\SOLAR BEBIDAS S.A\Service Desk - NOVA\Termos Monitores\"*/ +
                    list[0].FUNCIONARIO + "_" + DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + DateTime.Today.Day + ".pdf";

                using (Document doc = new Document(PageSize.A4))
                {
                    doc.SetMargins(50, 50, 50, 50);
                    doc.AddCreationDate();

                    CriarPasta();

                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

                    doc.Open();

                    string thisPath = Directory.GetCurrentDirectory();
                    string aux = thisPath.Substring(thisPath.IndexOf("bin"));
                    string img = thisPath.Substring(0, thisPath.Length - aux.Length) + "Properties\\Icones\\SOLA.png";

                    Image imgSolar = Image.GetInstance(img);
                    imgSolar.SetAbsolutePosition(400, 770);
                    imgSolar.ScaleAbsolute(146, 30);
                    doc.Add(imgSolar);

                    Paragraph titulo = new Paragraph("", new Font(Font.FontFamily.TIMES_ROMAN, 11));
                    titulo.Alignment = Element.ALIGN_CENTER;
                    titulo.Font = new Font(Font.FontFamily.TIMES_ROMAN, 11, (int)System.Drawing.FontStyle.Bold);

                    titulo.Add("\n\n\nTERMO DE RESPONSABILIDADE EQUIPAMENTOS TI\n\n\n");

                    doc.Add(titulo);

                    Paragraph paragrafo1 = new Paragraph("", new Font(Font.FontFamily.TIMES_ROMAN, 11));
                    paragrafo1.Font = new Font(Font.FontFamily.TIMES_ROMAN, 11, (int)System.Drawing.FontStyle.Regular);
                    paragrafo1.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo1.Add("Eu, ");
                    paragrafo1.Font = new Font(Font.FontFamily.TIMES_ROMAN, 11, (int)FontStyle.Bold);
                    paragrafo1.Add(list[0].FUNCIONARIO + ", ");
                    paragrafo1.Font = new Font(Font.FontFamily.TIMES_ROMAN, 11, (int)FontStyle.Regular);
                    paragrafo1.Add("portador do Registro do Empregado de número ");
                    paragrafo1.Font = new Font(Font.FontFamily.TIMES_ROMAN, 11, (int)FontStyle.Bold);
                    paragrafo1.Add(Base.FI.uctHome.txbMatricula.Text + ", ");
                    paragrafo1.Font = new Font(Font.FontFamily.TIMES_ROMAN, 11, (int)FontStyle.Bold);
                    paragrafo1.Add("na Diretoria de " + list[0].AREA + ", ");
                    paragrafo1.Font = new Font(Font.FontFamily.TIMES_ROMAN, 11, (int)FontStyle.Regular);
                    paragrafo1.Add("na Unidade de ");
                    paragrafo1.Font = new Font(Font.FontFamily.TIMES_ROMAN, 11, (int)FontStyle.Bold);
                    paragrafo1.Add(list[0].UND + ", ");
                    paragrafo1.Font = new Font(Font.FontFamily.TIMES_ROMAN, 11, (int)FontStyle.Regular);
                    paragrafo1.Add("ocupando a função de ");
                    paragrafo1.Font = new Font(Font.FontFamily.TIMES_ROMAN, 11, (int)FontStyle.Bold);
                    paragrafo1.Add(list[0].CARGO + ", ");
                    paragrafo1.Font = new Font(Font.FontFamily.TIMES_ROMAN, 11, (int)FontStyle.Regular);
                    paragrafo1.Add("assumo total responsabilidade sobre o(s) equipamento(s), listados no anexo 1, que estou recebendo, de comum acordo, da Solar BR.\n");

                    doc.Add(paragrafo1);

                    Paragraph paragrafo2 = new Paragraph("", new Font(Font.FontFamily.TIMES_ROMAN, 11));
                    paragrafo2.Font = new Font(Font.FontFamily.TIMES_ROMAN, 11, (int)FontStyle.Regular);
                    paragrafo2.Alignment = Element.ALIGN_JUSTIFIED;

                    paragrafo2.Add("Este equipamento será destinado para a execução dos meus misteres profissionais, " +
                        "mediante as condições abaixo, que são, desde já, por mim integralmente aceitas:\n\n1. O Usuário " +
                        "em posse deste equipamento não poderá efetuar (ou permitir) instalações de softwares não homologados " +
                        "pela área de TI da Norsa, bem como softwares que não possuam respectiva licença do fabricante, ficando o " +
                        "usuário responsável por toda e qualquer instalação ilegal de programas/softwares no equipamento acima " +
                        "descrito, enquanto o mesmo estiver em seu poder, isentando a Norsa de qualquer responsabilidade " +
                        "e/ou despesas associadas;\n\n2. Quando da devolução do equipamento acima descrito à Norsa, este" +
                        " deverá estar em perfeitas condições de uso, ressalvado o desgaste natural;\n\n3. O equipamento fica " +
                        "à disposição do usuário, sendo terminantemente proibido emprestá-lo ou repassá-lo, a qualquer título, para" +
                        " outras pessoas, sem a prévia comunicação e autorização ao Help Desk;\n\n4. No caso de encerramento do contrato" +
                        " de trabalho, o usuário deverá devolver o equipamento à Norsa no dia em que for comunicada a dispensa e/ou " +
                        "demissão juntamente com todos os acessórios informados neste termo;\n\n5. A utilização deste equipamento é " +
                        "oferecida por liberalidade da Norsa e está reserva-se o direito de suspendê-lo a qualquer momento, sem " +
                        "justificativa;\n\n6. Nos termos do art. 462 da CLT, o usuário deverá ressarcir a Norsa dos valores correspondentes " +
                        "em caso de dano ou dolo, e também quando caracterizado mau uso do equipamento. A reposição/conserto do " +
                        "equipamento e/ou seus acessórios será arcada pelo usuário que desde já autoriza o desconto em seus vencimentos, " +
                        "através de folha de pagamento. E por concordar integralmente com o acima estipulado, assino o presente Termo " +
                        "de Responsabilidade, em duas vias, juntamente com as testemunhas abaixo:");

                    paragrafo2.Add("\nCom o fim exclusivo pertinentes ao exercício do trabalho para o qual fui contratado " +
                        "e que o equipamento ora recebido se encontra em perfeito estado de conservação e utilização, comprometendo-me ainda a:" +
                        "\n\n1. Não utilizar o dispositivo móvel e seus acessórios para outros fins que não, sejam pertinentes ao exercício do " +
                        "trabalho para o qual fui contratado como funcionário da Solar BR:" +
                        "\n\n".PadRight(15) + "1.1. Tendo em vista que o equipamento que me foi disponibilizado possui o aplicativo de mensagens WhatsApp" +
                        "(“Aplicativo”), reconheço e concordo que (i) deverei utilizar o Aplicativo estritamente em função do meu trabalho e dos" +
                        " melhores interesses da Solar; e (ii) deverei respeitar, durante o tempo em que estiver utilizando o Aplicativo, as " +
                        "leis, as normas internas da Solar (incluindo o Código de Ética e Conduta) e todo e qualquer regulamento ou lei local, " +
                        "estadual, nacional ou internacional aplicável, uma vez que o uso do Aplicativo associado ao trabalho atrai a aplicação " +
                        "de todas as regras impostas aos empregados no seu ambiente de trabalho físico." +
                        "\n\n".PadRight(15) + "1.2. No sentido do item imediatamente acima, aceito e concordo que estarei sujeito a todas as sanções aplicáveis" +
                        " constantes da legislação brasileira, inclusive nos âmbitos trabalhista e criminal, na hipótese de transmissão, pelo " +
                        "Aplicativo, de qualquer conteúdo ou mídia que:" +
                        "\n".PadRight(15) + "a) Seja inverídica, falsa ou adulterada," + "\n".PadRight(15) + "b) Viole as regras atinentes à Lei Geral de Proteção de Dados Pessoais " +
                        "(“LGPD”), que protegem dados pessoais sensíveis, como número de telefone, endereço, informações financeiras e número de " +
                        "documentos ou qualquer outro conteúdo que represente risco ao usuário, à Solar ou a terceiros segundo a LGPD;" + "\n".PadRight(15) + "c) Viole" +
                        " direitos de terceiros, incluindo, mas sem limitação, direitos de propriedade intelectual;" + "\n".PadRight(15) + "d) Contenha conteúdo " +
                        "ofensivo, obsceno, difamatório, vexatório, ilegal, invasivo à privacidade, racista, preconceituoso, de cunho religioso ou " +
                        "político, corrente, ameaçador, abusivo, vulgar, injurioso, depreciativo ou de qualquer forma censurável, seja em relação a" +
                        " marcas, produtos e colaboradores da Solar ou a terceiros." + "\n".PadRight(15) + "e) Assumo a exclusiva responsabilidade pelo conteúdo " +
                        "trafegado por mim no Aplicativo e, deste modo, isentarei e/ou indenizarei a Solar por qualquer prejuízo sofrido por ela em" +
                        " decorrência de algum descumprimento das regras aqui contidas." +
                        "\n\n2. Ser responsável pela integridade do dispositivo móvel a partir do recebimento do referido aparelho, não deixando que" +
                        " terceiros tenham contato e utilizem o mencionado aparelho;" +
                        "\n\n3. Em caso de perda, quebra ou defeito por má utilização resultantes de negligência, imprudência ou imperícia, estou " +
                        "ciente que serei responsabilizado pelo pagamento do valor do dispositivo móvel e seus acessórios (valor de mercado) à Solar" +
                        " BR por intermédio de desconto em folha de pagamento, desconto este que desde já autorizo, ressalvada apenas a hipótese de" +
                        " roubo - aqui definido como quando o aparelho é subtraído mediante violência ou grave ameaça ou falhas não decorrentes de " +
                        "dolo de usuário ocorrido durante a jornada de trabalho. Fatos sujeitos à análise da Telefonia e à observação das " +
                        "obrigações contidas no item 4 seguintes." +
                        "\n\n".PadRight(15) + "3.1. Tenho ciência que comunicação falsa de crime está previsto no art. 340 do Código Penal, e é definido como: " +
                        "“provocar ação de autoridade policial comunicando-lhe ocorrência de crime que sabe não se ter verificado, sendo punida com " +
                        "pena de detenção de 1 a 6 meses, ou multa, estando sujeito as penalidades do regimento penal brasileiro e norma interna da " +
                        "Cia”." +
                        "\n\n4. No caso de roubo deverei: (i) informar imediatamente à TI da SOLAR através de abertura chamado no sistema de Service " +
                        "Desk a fim de bloquear todos os recursos dos dispositivos moveis, ocasião em que deverá fornecer o nome completo e o número " +
                        "do aparelho; (ii) informar ao Setor de Telefonia ou ao meu superior imediato; (iii) entregar à empresa o Boletim de " +
                        "Ocorrência do sinistro no prazo máximo de 48 (quarenta e oito) horas, sob pena de, se não o fizer, me responsabilizarei pelo" +
                        " pagamento do valor do dispositivo móvel (valor de mercado) à Solar BR." +
                        "\n\n5. Não utilizarei eventuais serviços oferecidos pela operadora, em especial os serviço ( torpedos, envios de fotos, " +
                        "downloads e uploads de jogos, arquivos e aplicações) ou outros da mesma espécie que venham a ser oferecidos; estou ciente que " +
                        "em caso de utilização de tais serviços serei responsabilizado pelo pagamento do valor dos mesmos à Solar BR, por intermédio de" +
                        " desconto em folha de pagamento, descontos estes que desde já autorizo, e estarei sujeito à advertência e punições " +
                        "administrativas em caso de reincidência." +
                        "\n\n6. Estou ciente ainda quanto as demais clausulas contidas na norma de serviços de comunicação móvel sujeitando-me ao " +
                        "total cumprimento da mesma.");

                    doc.Add(paragrafo2);

                    Paragraph localdata = new Paragraph("", new Font(Font.FontFamily.TIMES_ROMAN, 11));
                    localdata.Alignment = Element.ALIGN_CENTER;
                    localdata.Font = new Font(Font.FontFamily.TIMES_ROMAN, 11, (int)FontStyle.Regular);
                    localdata.Add("\n\n\n" + Base.Unidades.Where(x => x.Sigla == Base.Unidade).Select(x => x.Nome).First() + ", " + DateTime.Today.ToLongDateString() + "\n\n\n\n");
                    doc.Add(localdata);

                    doc.NewPage();
                    Paragraph paragrafo3 = new Paragraph("", new Font(Font.FontFamily.TIMES_ROMAN, 11));

                    paragrafo3.Font = new Font(Font.FontFamily.TIMES_ROMAN, 11, (int)FontStyle.Bold);
                    paragrafo3.Alignment = Element.ALIGN_CENTER;
                    paragrafo3.Add("Anexo 1\n\n");

                    paragrafo3.Font = new Font(Font.FontFamily.TIMES_ROMAN, 14, (int)FontStyle.Bold);
                    paragrafo3.Alignment = Element.ALIGN_CENTER;
                    paragrafo3.Add("LISTA DE EQUIPAMENTOS\n\n");

                    doc.Add(paragrafo3);
                    Paragraph paragrafo4 = new Paragraph("", new Font(Font.FontFamily.TIMES_ROMAN, 11));

                    //paragrafo4.Font = new Font(Font.FontFamily.TIMES_ROMAN, 11, (int)FontStyle.Regular);
                    //paragrafo4.Alignment = Element.ALIGN_LEFT;
                    //paragrafo4.Add("Equipamento: Monitor" + ", Modelo: " + modelo + ", Marca: " + marca +
                    //    ", Patrimônio: " + patrimonio + "\n\n\n\n" +
                    //    "Usuário: " + eq.Cliente.Nome + "\r\nRE:" + mat + "\r\n\nAssinatura:__________________________________\r\n\n\nUsuário: Sérgio Agostinho Fernandes Sousa\r\nRE:66003298\r\n\nAssinatura:_________________________________");

                    foreach (var i in list)
                    {
                        if (i.EQUIPAMENTO == "Desktop" || i.EQUIPAMENTO == "Notebook" || i.EQUIPAMENTO == "TinckClient")
                        {
                            paragrafo4.Font = new Font(Font.FontFamily.TIMES_ROMAN, 11, (int)FontStyle.Regular);
                            paragrafo4.Alignment = Element.ALIGN_LEFT;
                            paragrafo4.Add("Equipamento: " + i.EQUIPAMENTO + ", Modelo: " + i.MODELO + ", Marca: " + i.MARCA +
                                ", Série: " + i.SERIE + ", Patrimônio: " + i.PATRIMONIO + "\n");
                        }

                    }
                    paragrafo4.Font = new Font(Font.FontFamily.TIMES_ROMAN, 11, (int)FontStyle.Regular);
                    paragrafo4.Alignment = Element.ALIGN_LEFT;
                    paragrafo4.Add("Acessórios: " + acessorios + "\n");

                    paragrafo4.Font = new Font(Font.FontFamily.TIMES_ROMAN, 11, (int)FontStyle.Regular);
                    paragrafo4.Alignment = Element.ALIGN_LEFT;
                    paragrafo4.Add("----------------------------------------------------------------------------------------------------------------------------------");
                    doc.Add(paragrafo4);
                    doc.Close();

                }

            }
            catch
            {
                throw new DomainException("Erro ao gerar termo!");
            }
        }

        private static void CriarPasta()
        {

            if (!Directory.Exists(_path))
            {
                Directory.CreateDirectory(_path);
            }
        }
    }
}
