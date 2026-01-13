#region string p/ int

string texto = "abc";

int intDoTexto;

int.TryParse(texto, out intDoTexto);

#endregion

#region string p/ float

string numeroFloat = "abc";

float floatDoTexto;

float.TryParse(numeroFloat, out floatDoTexto);

#endregion

#region int p/ string

int numero = 10;

string stringDoNumero = numero.ToString();

#endregion

#region float p/ string

float numeroQuebrado = 10.5f;

string stringDoNumeroQuebrado = numeroQuebrado.ToString();

#endregion

#region bool p/ string

bool verdadeiroOuFalso = false;

string stringDoBool = verdadeiroOuFalso.ToString();

#endregion

#region float p/ int

float numeroQuebrado2 = 10.6f;

int intNumero2 = (int)numeroQuebrado2;

#endregion

#region int p/ float

int numero3 = 3;

float numeroFloat3 = numero3;

#endregion