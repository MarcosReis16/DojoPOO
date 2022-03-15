//João tem uma fazenda que possui alguns animais. Cada animal
//da fazenda produz um tipo de produto, os quais geram receita para
// a fazenda. João possui galinhas, vacas e ovelhas. Cada animal possui
// um código de registro numérico, e cada produto possui o seu valor.
// O programa abaixo serve para registrar todas essas informações
// e valores gerados mensalmente, mas está ficando cada vez maior e complexo. Você
// poderia nos ajudar?
// Subentende-se que os ovos gerados pela galinha são contabilizados
// por unidade, o leite que a vaca produz é por litro, e a lã
// produzida pelas ovelhas é através do Kg.

int galinha1Registro = 1;
double galinha1ValorGerado = 350 * 0.15;
int galinha2Registro = 2;
double galinha2ValorGerado = 225 * 0.15;
int galinha3Registro = 3;
double galinha3ValorGerado = 440 * 0.15;
int galinha4Registro = 4;
double galinha4ValorGerado = 282 * 0.15;

int vaca1Registro = 5;
double vaca1ValorGerado = 60 * 4.4;
int vaca2Registro = 6;
double vaca2ValorGerado = 67 * 4.4;
int vaca3Registro = 7;
double vaca3ValorGerado = 90 * 4.4;

int ovelha1Registro = 8;
double ovelha1ValorGerado = 5.5 * 90;
int ovelha2Registro = 9;
double ovelha2ValorGerado = 6 * 90;
int ovelha3Registro = 10;
double ovelha3ValorGerado = 7 * 90;
int ovelha4Registro = 11;
double ovelha4ValorGerado = 14 * 90;
int ovelha5Registro = 12;
double ovelha5ValorGerado = 11 * 90;

int quantidadeDeAnimais = 12;

double receitaGeradaPelosAnimais = galinha1ValorGerado +
galinha2ValorGerado + galinha3ValorGerado + galinha4ValorGerado +
vaca1ValorGerado + vaca2ValorGerado + vaca3ValorGerado +
ovelha1ValorGerado + ovelha2ValorGerado + ovelha3ValorGerado +
ovelha4ValorGerado + ovelha5ValorGerado;

Console.WriteLine($"Atualmente João possui {quantidadeDeAnimais}");
Console.WriteLine($"A receita gerada pelos animais esse mês foi de R$ {receitaGeradaPelosAnimais}");