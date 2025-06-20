namespace LinkedListTest;

using Classes;
using NUnit.Framework;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Add_AddsElementToEndOfList()
    {
        var list = new LinkedList<int>(1);
        list.add(10);
        list.add(30);
        Assert.That(list.size(), Is.EqualTo(2), "El tamaño de la lista debe ser 2 ya que se agregaron 2 elementos a la lista");
    }

    [Test]
    public void Remove_RemovesElementFromList()
    {
        var list = new LinkedList<int>(100);
        list.add(200);
        list.add(300);
        list.remove(200);

        Assert.That(list.size(), Is.EqualTo(1), "La lista debería tener un solo valor agregado después de eliminar el número 200.");
        Assert.That(list.search(1), Is.EqualTo(300), "Luego de eliminar el 200, el siguiente valor en la lista debería ser 300.");
    }

    [Test]
    public void Size_ReturnsCorrectCount()
    {
        var list = new LinkedList<int>(10);
        list.add(20);
        list.add(30);
        Assert.That(list.size(), Is.EqualTo(2), "La lista debería contener 2 elementos agregados después del primero.");
    }

    [Test] // Esta prueba falla ya que el metodo search no avanza correctamente por la lista ya que el counter no se incrementa en el while
    public void AddIn_InsertsElementAtCorrectPosition()
    {
        var list = new LinkedList<int>(50);
        list.add(100);
        list.addIn(75, 0);

        Assert.That(list.search(1), Is.EqualTo(75), "El número 75 debería estar en la segunda posición después de insertarlo entre 50 y 100.");
    }

    [Test]
    public void GetLast_ReturnsLastElement()
    {
        var list = new LinkedList<string>("uno");
        list.add("dos");
        list.add("tres");

        Assert.That(list.getLast(0), Is.EqualTo("tres"), "El último valor de la lista debería ser 'tres'.");
    }
    [Test]
    public void PrintList_ImprimeValoresEsperados()
    {
        var list = new LinkedList<int>(5);
        list.add(15);
        list.add(25);

        var consola = new StringWriter();
        Console.SetOut(consola);

        list.printList();

        var texto = consola.ToString().Trim().Replace("\r", "");
        Assert.That(texto, Is.EqualTo("5\n15\n25"), "La consola debería mostrar los valores 5, 15 y 25 en orden, uno por línea.");
    }


}
