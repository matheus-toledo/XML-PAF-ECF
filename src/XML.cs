using System;
using System.Xml;
using System.IO;

namespace GeraXML {
    class XML {
        public static string nr_laudo { get; set; }
        private static XmlWriter laudo;
        private static XmlWriterSettings config;
        public static bool tem_retaguarda { get; set; } = false;
        public static bool tem_ped { get; set; } = false;
        public static uint qtd_retaguardas { get; set; }
        public static uint qtd_ped { get; set; }


        public static void deleta_XML() {
            laudo.Close();
            File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + nr_laudo + "SEMASSINAR.xml");
        }

        public static void Insere_Campos_1_a_6(string elemento) {
            config = new XmlWriterSettings();
            config.Indent = true;
            config.Encoding = UpperCaseUTF8Encoding.UpperCaseUTF8;
            
            laudo = XmlWriter.Create(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + nr_laudo + "SEMASSINAR.xml", config);
            laudo.WriteStartDocument();
            
            laudo.WriteStartElement("Laudo");
            laudo.WriteAttributeString("Versao", "1.0");

            laudo.WriteStartElement("Mensagem");

            laudo.WriteElementString("Numero", elemento);
            laudo.WriteElementString("EmiteNfe", "true");

        }

        public static void Insere_Campos_7_a_24(string[] valores) {
            laudo.WriteStartElement("Desenvolvedora");

            laudo.WriteElementString("RazaoSocial", valores[0]);
            laudo.WriteElementString("Cnpj", valores[1]);
            laudo.WriteElementString("Ie", valores[2]);

            laudo.WriteStartElement("Endereco");

            laudo.WriteElementString("Logradouro", valores[3]);
            laudo.WriteElementString("Numero", valores[4]);
            laudo.WriteElementString("Complemento", valores[5]);
            laudo.WriteElementString("Bairro", valores[6]);
            laudo.WriteElementString("Municipio", valores[7]);
            laudo.WriteElementString("Uf", valores[8]);
            laudo.WriteElementString("Cep", valores[9]);
            laudo.WriteEndElement();

            laudo.WriteStartElement("Contato");

            laudo.WriteElementString("Nome", valores[10]);
            laudo.WriteElementString("Cpf", valores[11]);
            laudo.WriteElementString("Telefone", valores[12]);
            laudo.WriteElementString("Email", valores[13]);
            laudo.WriteEndElement();

            laudo.WriteElementString("ResponsavelAcompanhamentoTestes", valores[14]);

            laudo.WriteEndElement();

        }

        public static void Insere_Campos_25_a_40(string[] valores) {
            laudo.WriteStartElement("Otc");

            laudo.WriteElementString("RazaoSocial", valores[0]);
            laudo.WriteElementString("Cnpj", valores[1]);
            laudo.WriteElementString("Ie", valores[2]);

            laudo.WriteStartElement("Endereco");

            laudo.WriteElementString("Logradouro", valores[3]);
            laudo.WriteElementString("Numero", valores[4]);
            laudo.WriteElementString("Complemento", valores[5]);
            laudo.WriteElementString("Bairro", valores[6]);
            laudo.WriteElementString("Municipio", valores[7]);
            laudo.WriteElementString("Uf", valores[8]);
            laudo.WriteElementString("Cep", valores[9]);
            laudo.WriteEndElement();

            laudo.WriteStartElement("PeriodoAnalise");

            laudo.WriteElementString("DataInicio", valores[10]);
            laudo.WriteElementString("DataFim", valores[11]);
            laudo.WriteEndElement();
            laudo.WriteElementString("VersaoEspecificacaoRequisitos", valores[12]);

            laudo.WriteEndElement();
        }

        public static void Insere_Campos_41_a_51(string[] valores) {
            laudo.WriteStartElement("IdentificacaoPaf");

            laudo.WriteElementString("NomeComercial", valores[0]);
            laudo.WriteElementString("Versao", valores[1]);

            laudo.WriteStartElement("ArquivoExecutavelPrincipal");

            laudo.WriteElementString("Nome", valores[2]);
            laudo.WriteElementString("Md5", valores[3]);

            laudo.WriteEndElement();

            laudo.WriteStartElement("ArquivoRelacaoExecutaveis");

            laudo.WriteElementString("Nome", valores[4]);
            laudo.WriteElementString("Md5", valores[5]);

            laudo.WriteEndElement();

            laudo.WriteStartElement("ArquivosExecutaveis");



        }

        public static void Insere_Campos_52_e_53(string nome, string md5) {
            laudo.WriteStartElement("ArquivoExecutavel");

            laudo.WriteElementString("Nome", nome);
            laudo.WriteElementString("Md5", md5);

            laudo.WriteEndElement();
        }

        public static void Insere_Campos_54_ao_63(string[] valores, string nome_relacaoexe, string md5_relacaoexe) {
            laudo.WriteEndElement();

            laudo.WriteStartElement("ArquivosOutros");

            laudo.WriteStartElement("ArquivoOutro");

            laudo.WriteElementString("Nome", nome_relacaoexe);
            laudo.WriteElementString("Md5", md5_relacaoexe);

            laudo.WriteEndElement();
            laudo.WriteEndElement();

            laudo.WriteStartElement("EnvelopeSeguranca");

            laudo.WriteElementString("Marca", valores[0]);
            laudo.WriteElementString("Modelo", valores[1]);
            laudo.WriteElementString("Numero", valores[2]);

            laudo.WriteEndElement();

            laudo.WriteStartElement("PerfisRequisitos");

            laudo.WriteElementString("PerfilRequisito", valores[3]);

            laudo.WriteEndElement();

            laudo.WriteEndElement();



        }

        public static void Insere_Campos_64_a_72(string[] valores) {
            uint x = 2;
            uint i = 1;
            laudo.WriteStartElement("CaracteristicasPaf");

            laudo.WriteElementString("LinguagemProgramacao", valores[0]);
            laudo.WriteElementString("SistemaOperacional", valores[1]);

            while (i <= 5) {
                if (!String.IsNullOrEmpty(valores[x]))
                    laudo.WriteElementString("GerenciadorBancoDados", valores[x]);
                x++;
                i++;
            }

            i = 1;
            x = 9;

            laudo.WriteElementString("TipoDesenvolvimento", valores[7]);
            laudo.WriteElementString("TipoFuncionamento", valores[8]);

            laudo.WriteStartElement("MeioGeracaoArquivoSintegraEfd");
            while (i <= 3) {
                if (!String.IsNullOrEmpty(valores[x]))
                    laudo.WriteElementString("Modo", valores[x]);
                i++;
                x++;
            }

            laudo.WriteEndElement();

            laudo.WriteElementString("IntegracaoPaf", valores[12]);



        }

        public static void Isere_Campos_73_a_78(string[] impressao, string[] tratamento, string[] ap_esp) {

            laudo.WriteStartElement("FormaImpressao");

            foreach (string st in impressao) {
                if (!String.IsNullOrEmpty(st))
                    laudo.WriteElementString("Modo", st);
            }

            laudo.WriteEndElement();

            laudo.WriteStartElement("TratamentoInterrupcao");

            foreach (string tr in tratamento) {
                if (!String.IsNullOrEmpty(tr))
                    laudo.WriteElementString("Modo", tr);
            }

            laudo.WriteEndElement();

            laudo.WriteStartElement("AplicacoesEspeciais");

            foreach (string ap in ap_esp) {
                if (!String.IsNullOrEmpty(ap))
                    laudo.WriteElementString("AplicacaoEspecial", ap);
            }

            laudo.WriteEndElement();

            laudo.WriteEndElement();

           


        }

        public static void Insere_Emp_Desenvol_Ret_PED_NFe(string ident_tag, string[] valores) {
            Abre_tag_retaguarda_ped_ou_NFe(ident_tag);

            if (ident_tag == "retaguarda")
                laudo.WriteStartElement("SistemaGestao");
            else if (ident_tag == "ped")
                laudo.WriteStartElement("SistemaPed");
            else
                laudo.WriteStartElement("SistemaPedNfe");


            laudo.WriteElementString("Nome", valores[0]);

            laudo.WriteStartElement("EmpresaDesenvolvedora");

            laudo.WriteElementString("RazaoSocial", valores[1]);
            laudo.WriteElementString("Cnpj", valores[2]);

            laudo.WriteEndElement();

            laudo.WriteStartElement("ArquivosExecutaveis");
        }

        private static void Abre_tag_retaguarda_ped_ou_NFe(string ident_tag) {
            if (ident_tag == "retaguarda")
                laudo.WriteStartElement("SistemasGestao");
            else if (ident_tag == "ped")
                laudo.WriteStartElement("SistemasPed");
            else
                laudo.WriteStartElement("SistemasPedNfe");
        }


        public static void Insere_Arq_Executavel (string arquivo, string md5, string funcao) {
            laudo.WriteStartElement("ArquivoExecutavel");

            laudo.WriteElementString("Nome", arquivo);
            laudo.WriteElementString("Md5", md5);
            laudo.WriteElementString("Funcao", funcao);

            laudo.WriteEndElement(); 
        }

        public static void Insere_Arq_Executavel(string arquivo, string md5, string[] requisitos) {


            laudo.WriteStartElement("ArquivoExecutavel");

            laudo.WriteElementString("Nome", arquivo);
            laudo.WriteElementString("Md5", md5);


            laudo.WriteStartElement("RequisitosExecutados");

            foreach (string st in requisitos) {
                laudo.WriteElementString("RequisitoExecutado", st);
            }

            laudo.WriteEndElement();

            laudo.WriteEndElement();
        }

        /// <summary>
        /// Fecha completamente uma tag
        /// </summary>
        public static void fecha_tag() {
            laudo.WriteEndElement();
        }

        public static void sem_ret_ou_ped(string ident_tag) {
            if (ident_tag == "retaguarda")
                laudo.WriteStartElement("SistemasGestao");
            else
                laudo.WriteStartElement("SistemasPed");
            fecha_tag();
        }

        public static void Insere_Campos_ECF_teste_ou_compativeis(string tag) {
            laudo.WriteStartElement(tag);

        }

        public static void Insere_Campos_115_e_116(string marca, string modelo) {
            laudo.WriteStartElement("MarcaModelo");

            laudo.WriteElementString("Marca",marca);
            laudo.WriteElementString("Modelo", modelo);

            laudo.WriteEndElement();

        }

        public static void Insere_Campos_121_a_131(string[] valores, bool declaracao) {
            laudo.WriteElementString("VersaoErPaf", valores[0]);

            laudo.WriteStartElement("RoteiroAnalise");

            laudo.WriteElementString("VersaoRoteiro", valores[1]);
            laudo.WriteElementString("Mes", valores[2]);
            laudo.WriteElementString("Ano", valores[3]);

            laudo.WriteEndElement();

            laudo.WriteElementString("NaoConformidades", "");

            laudo.WriteElementString("ComentarioOtc", valores[4]);

            laudo.WriteElementString("Declaracao", declaracao.ToString().ToLower());
            
        }

        public static void Insere_Campos_133_a_143(string[] valores) {
            laudo.WriteStartElement("Emissao");

            laudo.WriteElementString("Data", valores[0]);
            laudo.WriteElementString("Local", valores[1]);

            laudo.WriteEndElement();

            laudo.WriteStartElement("ExecucaoTestes");

            laudo.WriteElementString("Nome", valores[2]);
            laudo.WriteElementString("Cargo", valores[3]);
            laudo.WriteElementString("Cpf", valores[4]);

            laudo.WriteEndElement();

            laudo.WriteStartElement("AprovacaoRelatorio");

            laudo.WriteElementString("Nome", valores[5]);
            laudo.WriteElementString("Cargo", valores[6]);
            laudo.WriteElementString("Cpf", valores[7]);

            laudo.WriteEndElement();

            Fecha_XML();

        }



        public static void Fecha_XML() {
            laudo.WriteEndDocument();
            laudo.Close();
        }

    }
}
