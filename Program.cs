/*
 Decorator Pattern permit to add some functionality trough composition to an object without change the original object's structure.
 */

//simulations of input
using Structural_Decorator;

string url = "aaa.bbbbbbb.cc";
string data = "My personal data to manage";
bool compress = true;
bool encrypt = true;

CloudDataNAIVE cloudData = new CloudDataNAIVE(url);
if (compress && encrypt)
{
	cloudData = new CompressedAndEncryptedDataNAIVE(url);
}
else if (encrypt)
{
	cloudData = new EncryptDataNAIVE(url);
}
else if (compress)
{
	cloudData = new CompressDataNAIVE(url);
}
cloudData.Save(data);

Console.WriteLine("*********Using decorator solution");

IData  cloudDataDecorator = new CloudData(url);
if (encrypt)
{
	//in this case we WRAPPING or DECORATE the clouddata with/inside a EncryptionDecorator class
	//without create o specific subclass
	cloudDataDecorator = new EncryptionDecorator(cloudDataDecorator);
}
if (compress)
{
	cloudDataDecorator  = new CompressionDecorator(cloudDataDecorator);
}
//if you need to add a new condition, you mustn't create new classes for all possible combination, you need create only new decorator for the new purposes
cloudDataDecorator.Save(data);