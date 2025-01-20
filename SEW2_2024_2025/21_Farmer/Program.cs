using _21_Farmer;

Farmer mcDonald = new Farmer("Ronald", "McDonald", new Cat("Minka", "grau"));

mcDonald.myDog = new Dog("Erik", "Terrier");
if (mcDonald.myDog != null)
{
    Console.WriteLine(mcDonald.myDog.Name);
}

mcDonald.myDog = null;

if(mcDonald.myDog != null)
{
    Console.WriteLine(mcDonald.myDog.Name);
}
                                            //myDog is null
                                            //--> NullReferenceException
mcDonald.myDog = new Dog("Blacy", "Labrador-Retriever");

//Namen des Hundes vom McDonald
if (mcDonald.myDog != null)
{
    Console.WriteLine(mcDonald.myDog.Name);
}

Console.WriteLine(mcDonald.myCat.Name);

//mcDonald.myCat = null;
