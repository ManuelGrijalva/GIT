//multiplicacion//

byte digito1, digito2;

ushort resultado;

Console.WriteLine("Ingresa dos Digitos para Multiplicar:");
Console.WriteLine("digito1:");
digito1 = Convert.ToByte(Console.ReadLine());
Console.WriteLine("digito2:");
digito2 = Convert.ToByte(Console.ReadLine());
resultado = Convert.ToUInt16(digito1 * digito2);
Console.WriteLine("Resultado de la operacion:" + resultado);
