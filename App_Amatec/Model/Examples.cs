using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Amatec.Model
{

    public class Examples
    {

        // Animes:

        public static List<Content> animes = new List<Content>()
        {
        
            new Content()
            {

                nome = "Demon Slayer\n(Temporada 04)",

                sinopse = "Japão, era Taisho. Tanjiro, um bondoso jovem que ganha a vida vendendo carvão, " +
                          "descobre que sua família foi massacrada por um demônio, e, para piorar, Nezuko, sua " +
                          "irmã mais nova, e única sobrevivente, também foi transformada em um demônio. Arrasado com " +
                          "esta sombria realidade, ele decide se tornar um matador de demônios, para fazer sua " +
                          "irmã voltar a ser humana, e para matar o demônio que matou sua família. Um triste conto " +
                          "sobre dois irmãos, onde os destinos dos humanos e dos demônios se entrelaçam, começa agora.",

                poster = "App_Amatec.Assets.Images.Animes.01.jpg",

                data_lancamento = new DateTime(2024, 05, 12),

                forma_consumo = "Crunchyroll",

                link_trailer = "https://www.youtube.com/embed/k9ex2xuoQZs?si=GvXTpcF6BukiQ2n6"

            },

            new Content()
            {

                nome = "Solo Leveling\n(Temporada 02)",

                sinopse = "Conhecido como o caçador mais fraco de toda a humanidade, a contribuição do caçador de " +
                          "rank E, Sung Jin Woo, nas invasões de masmorras, se resume ao equivalente a tentar não ser morto. " +
                          "Infelizmente, entre as contas do hospital de sua mãe, as mensalidades escolares de sua irmã e sua " +
                          "própria falta de perspectivas de emprego, ele não tem escolha a não ser continuar colocando sua vida em risco. " +
                          "Então, quando surge uma oportunidade para um pagamento maior, ele aceita… apenas para ficar " +
                          "cara a cara com um ser cujo poder supera tudo o que ele já viu! Com o líder do grupo sem um " +
                          "braço, e a única curandeira em estado de choque, ele conseguirá encontrar uma saída de alguma forma?",

                poster = "App_Amatec.Assets.Images.Animes.02.jpg",

                data_lancamento = new DateTime(2024, 08, 31),

                // Data fictícia. A data de lançamento será substituída em breve.

                forma_consumo = "Crunchyroll",

                link_trailer = "https://www.youtube.com/embed/hYzNkVCIUfk?si=V27KxTZzZaEL6MtN"

            },

            new Content()
            {

                nome = "Kaiju Nº 8\n(Temporada 01)",

                sinopse = "Monstros grotescos, semelhantes ao Godzilla e conhecidos pelo termo “Kaiju”, têm surgido pelo " +
                          "Japão durante vários anos. Para lutar contra essas feras, uma unidade militar de elite, " +
                          "denominada Corpo de Defesa, arrisca as vidas de seus membros todos os dias para proteger a população civil. " +
                          "Após a morte de uma criatura, os “varredores”, empregados pela Corporação Profissional de " +
                          "Limpeza de Kaiju, são responsáveis por eliminar seus restos mortais. Kafka Hibino, um homem de " +
                          "32 anos, não está satisfeito com seu trabalho como varredor. Desde jovem, ele sonha em se " +
                          "juntar ao Corpo de Defesa e viver para matar kaijus, no entanto, após algumas tentativas " +
                          "frustradas, ele desiste de seus sonhos e se conforma com uma vida de mediocridade, que ao menos, " +
                          "lhe garante um bom salário. Contudo, a chegada de um jovem recruta ambicioso, de 18 anos, chamado " +
                          "Leno Ichikawa, em sua equipe de limpeza, o faz reacender seu desejo de entrar para o exército do Corpo de Defesa. " +
                          "Após uma série de eventos infelizes, e um encontro com o varredor mais novo, Kafka tem um encontro " +
                          "com um kaiju parasita, que entra em seu corpo, através de sua boca, transformando-o em um monstro humanoide. " +
                          "Com seus novos poderes, Kafka decide dar mais uma chance ao seu sonho de vida.",

                poster = "App_Amatec.Assets.Images.Animes.03.jpg",

                data_lancamento = new DateTime(2024, 04, 13),

                forma_consumo = "Crunchyroll",

                link_trailer = "https://www.youtube.com/embed/qGvHTuFeulM?si=p2figzdQINK6cZex"

            },

            new Content()
            {

                nome = "Wind Breaker\n(Temporada 01)",

                sinopse = "Aqui as médias de notas são mais baixas, mas as lutas são as mais intensas! A Escola " +
                          "Furin é conhecida como uma superescola de delinquentes! Haruka Sakura, um estudante do " +
                          "primeiro ano do ensino médio, veio de fora da cidade pronto para lutar e conquistar o topo… " +
                          "No entanto, a Escola Furin acabou se tornando um grupo que protege a cidade! É aqui que a " +
                          "lenda heroica do delinquente Sakura no ensino médio começa!",

                poster = "App_Amatec.Assets.Images.Animes.04.jpg",

                data_lancamento = new DateTime(2024, 04, 04),

                forma_consumo = "Crunchyroll",

                link_trailer = "https://www.youtube.com/embed/k_CItzO4DkA?si=C-Ul5EGTW0WZmFtr"

            },

            new Content()
            {

                nome = "Kenka Dokugaku\n(Temporada 01)",

                sinopse = "O estudante magricelo do ensino médio, Hobin Yu, é provavelmente o último cara que você " +
                          "esperaria ver como protagonista de um canal do NewTube focado em lutas, mas depois de " +
                          "seguir alguns conselhos que viu em um misterioso canal no NewTube, ele começa a derrotar " +
                          "caras bem mais fortes que o mesmo e ganha mais dinheiro do que jamais poderia imaginar. " +
                          "Será que Hobin conseguirá manter isso? Ou acabará encontrando um adversário à altura?",

                poster = "App_Amatec.Assets.Images.Animes.05.jpg",

                data_lancamento = new DateTime(2024, 04, 11),

                forma_consumo = "Crunchyroll",

                link_trailer = "https://www.youtube.com/embed/y1Z1e7jC0eo?si=kEVZxv1gLOY2QokE"

            },

            new Content()
            {

                nome = "Fairy Tail\n(Missão de 100 anos)",

                sinopse = "Um ano depois que a guilda Fairy Tail superou as forças diabólicas " +
                          "de Acnologia e Zeref, Natsu e sua equipe viajam para o continente " +
                          "norte de Guiltina, onde procuram o empregador da Quest de 100 Anos " +
                          "e recebem sua missão quase impossível: selar os Cinco Deuses Dragões " +
                          "(Eles são um grupo de indivíduos com um poder tão grande que, se deixados " +
                          "sozinhos, poderiam causar uma devastação global.). Enquanto isso, um " +
                          "novo membro espirituoso, chamada Touka, é recrutado para a Fairy Tail. " +
                          "Embora sua energia vibrante e natureza apaixonada a tornem perfeita " +
                          "para a guilda, parece haver mais nela do que aparenta.",

                poster = "App_Amatec.Assets.Images.Animes.06.jpg",

                data_lancamento = new DateTime(2024, 07, 07),

                forma_consumo = "Crunchyroll",

                link_trailer = "https://www.youtube.com/embed/tFvzUUdMAug?si=Hs2-s_RLjPo6f1Uz"

            }

        };

        // Filmes:

        public static List<Content> movies = new List<Content>()
        {

            new Content()
            {

                nome = "Deadpool & Wolverine",

                sinopse = "Wolverine está se recuperando, quando cruza seu caminho com o de Deadpool. " +
                          "Juntos, eles formam uma equipe e enfrentam um inimigo em comum.",

                poster = "App_Amatec.Assets.Images.Movies.01.jpg",

                data_lancamento = new DateTime(2024, 07, 26),

                forma_consumo = "Cinemas",

                link_trailer = "https://www.youtube.com/embed/dEbe0rS4Z2A?si=sY2jDr8Z2vr5up5G"

            },

            new Content()
            {

                nome = "Uma ideia de você",

                sinopse = "Solène, uma mãe solteira de 40 anos, embarca em um romance inesperado com Hayes " +
                          "Campbell, o vocalista de 24 anos da August Moon, a banda de garotos mais popular do planeta.",

                poster = "App_Amatec.Assets.Images.Movies.02.jpg",

                data_lancamento = new DateTime(2024, 05, 02),

                forma_consumo = "Amazon\nPrime Vídeo",

                link_trailer = "https://www.youtube.com/embed/ZeIGZdfmBhg?si=wGgkBLYvF6DCl-8i"

            },

            new Content()
            {

                nome = "Mufasa: o rei leão",

                sinopse = "Mufasa, um filhote órfão, perdido e sozinho, conhece um simpático leão, chamado " +
                          "Taka, herdeiro de uma linhagem real. O encontro ao acaso, dá início a uma grande " +
                          "jornada de um grupo extraordinário de deslocados em busca de seu destino, além de " +
                          "revelar a ascensão de um dos maiores reis das Terras do Orgulho.",

                poster = "App_Amatec.Assets.Images.Movies.03.jpg",

                data_lancamento = new DateTime(2024, 12, 19),

                forma_consumo = "Cinemas",

                link_trailer = "https://www.youtube.com/embed/ZSD6LVpRi-k?si=YwBxkDlbedBMPgrc"

            },

            new Content()
            {

                nome = "Venom: a última rodada",

                sinopse = "Eddie e Venom estão em fuga. Caçados por figuras de ambos os seus mundos, " +
                          "e com os caminhos se fechando, a dupla é forçada a unir forças em sua aventura final.",

                poster = "App_Amatec.Assets.Images.Movies.04.jpg",

                data_lancamento = new DateTime(2024, 10, 24),

                forma_consumo = "Cinemas",

                link_trailer = "https://www.youtube.com/embed/c-1i96qpF-s?si=i4o7dexr8Dclnij4"

            },

            new Content()
            {

                nome = "Operação Natal",

                sinopse = "Depois que o Papai Noel (Também chamado de Das Neves.) é sequestrado, o Chefe " +
                          "de Segurança do Polo Norte (Dwayne Johnson) deve se unir ao mais infame caçador " +
                          "de recompensas do mundo (Chris Evans) em uma missão global e cheia de ação para " +
                          "salvar o Natal.",

                poster = "App_Amatec.Assets.Images.Movies.05.jpg",

                data_lancamento = new DateTime(2024, 11, 14),

                forma_consumo = "Cinemas",

                link_trailer = "https://www.youtube.com/embed/JE1fRhgrO3k?si=ZFZpWph3lvc5Yk5x"

                // O trailer será substituído em breve.

            },

            new Content()
            {

                nome = "Gladiador II",

                sinopse = "A história é focada em Lucius, anos depois de testemunhar a morte do venerado " +
                          "herói Maximus. Ele é forçado a entrar no Coliseu, após seu lar ser conquistado " +
                          "pelos imperadores tirânicos que agora comandam Roma com mão de ferro.",

                poster = "App_Amatec.Assets.Images.Movies.06.jpg",

                data_lancamento = new DateTime(2024, 11, 14),

                forma_consumo = "Cinemas",

                link_trailer = "https://www.youtube.com/embed/Gvu6ktSUln0?si=EyaZ1T4Yz1KDmTHD"

            }

        };

        // Séries:

        public static List<Content> series = new List<Content>()
        {

            new Content()
            {

                nome = "Bridgerton\n(Temporada 03)",

                sinopse = "Penelope sairá em busca de um marido, de preferência um que lhe ofereça " +
                          "independência o suficiente para que ela siga sua vida dupla como a grande Lady " +
                          "Whistledown. Enquanto isso, Colin retorna de suas viagens de verão.",

                poster = "App_Amatec.Assets.Images.Series.01.jpg",

                data_lancamento = new DateTime(2024, 05, 16),

                forma_consumo = "Netflix",

                link_trailer = "https://www.youtube.com/embed/sA6xIbcaZsw?si=VjcmX_tYyIzqtSy4"

            },

            new Content()
            {

                nome = "The Boys\n(Temporada 04)",

                sinopse = "Nos novos episódios de The Boys, o mundo está à beira de um colapso. " +
                          "Victoria Neuman está mais perto do que nunca do Salão Oval e sob o " +
                          "domínio de Capitão Pátria, que está consolidando seu poder. Billy Bruto, " +
                          "com apenas alguns meses restantes de vida, perdeu o filho de Becca e seu " +
                          "emprego como líder dos The Boys. O resto da equipe está farto de suas " +
                          "mentiras. Com os riscos mais altos do que nunca, eles precisam encontrar " +
                          "uma maneira de trabalhar juntos e salvar o mundo antes que seja tarde demais.",

                poster = "App_Amatec.Assets.Images.Series.02.jpg",

                data_lancamento = new DateTime(2024, 06, 13),

                forma_consumo = "Amazon\nPrime Vídeo",

                link_trailer = "https://www.youtube.com/embed/m1lv458bxdg?si=9QwPJ846MpZ9hskr"

            },

            new Content()
            {

                nome = "Cobra Kai\n(Temporada 06 Parte 01)",

                sinopse = "Com o Cobra Kai fora do Regional, os senseis e alunos precisam decidir se vão competir " +
                          "no Sekai Taikai, o torneio mundial de caratê, e como farão isso.",

                poster = "App_Amatec.Assets.Images.Series.03.jpg",

                data_lancamento = new DateTime(2024, 07, 18),

                forma_consumo = "Netflix",

                link_trailer = "https://www.youtube.com/embed/0TAXIXlY69I?si=nn2cddZLannTc4Yx"

            },

            new Content()
            {

                nome = "Fallout\n(Temporada 01)",

                sinopse = "Baseada em uma das maiores séries de videogame de todos os tempos, Fallout " +
                          "é a história de quem tem e de quem não tem, em um mundo onde não existe quase " +
                          "nada para se ter. 200 anos após o apocalipse, uma habitante pacífica, de um " +
                          "agradável refúgio, é forçada a se aventurar na superfície, e fica chocada quando " +
                          "descobre a terra devastada que a espera.",

                poster = "App_Amatec.Assets.Images.Series.04.jpg",

                data_lancamento = new DateTime(2024, 04, 11),

                forma_consumo = "Amazon\nPrime Vídeo",

                link_trailer = "https://www.youtube.com/embed/zGyKzPsmxF8?si=d6g2GTEw4EXd7Vx0"

            },

            new Content()
            {

                nome = "Avatar\n(Temporada 01)",

                sinopse = "As quatro nações viviam em harmonia com o Avatar, mestre de todos os quatro elementos, " +
                          "mantendo a paz entre todos, mas tudo mudou, quando a Nação do Fogo atacou e exterminou os " +
                          "Nômades do Ar, para os dobradores de fogo conquistarem o mundo. Com o desaparecimento do " +
                          "Avatar, o mundo perdeu a esperança.",

                poster = "App_Amatec.Assets.Images.Series.05.jpg",

                data_lancamento = new DateTime(2024, 02, 22),

                forma_consumo = "Netflix",

                link_trailer = "https://www.youtube.com/embed/5llvd1Uu-iU?si=nHIVsx-YYpeepP3W"

            }

        };

    }

}