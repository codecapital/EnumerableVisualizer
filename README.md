# EnumerableVisualizer
Visual Studio Debugger Enumerable Visualizer without any [Serialize] attribute, using Json. Works only with .NET.

*The .NET Core support might come with [Visual Studio 2019](https://developercommunity.visualstudio.com/content/idea/351618/custom-debugger-visualizer-for-net-core-apps-in-vs.html)*.

This is a still work in progres. Pretty much it is an un-edited experiment.

## Source
- https://github.com/JeremyThomas/rapiddevbookcode/blob/LLBL_Pro_v4.2/AW.DebugVisualizers/VisualizerRegistrations.cs
- https://raw.githubusercontent.com/JeremyThomas/rapiddevbookcode/LLBL_Pro_v4.2/AW.DebugVisualizers/VisualizerRegistrations.cs
- https://github.com/MBulli/MathNetDebugVisualizer
- https://wrightfully.com/series/debugger-visualizer
- https://github.com/ChenDaqian/Visual-Studio-Visualizer
- https://github.com/moraleslarios/MLCollectionVisualizers
- https://github.com/huanent/Huanent.VisualStudio.DebuggerVisualizers

## Features
- Visual Studio 2017, 2019
- One level nesting, deeper items displayed in json string
- Displaying result in **DataTable** in **DataGridView**
- Column sorting
- Filter and highlight searched words
- Select, copy and paste to Excel
- Currently supported: List<>, Array, ArrayList

## Installation
Copy the following files to your version of Visual Studio c:\Users\YOUR-PROFILE-NAME\Documents\Visual Studio 2017\Visualizers\

- CodeCapital.EnumerableVisualizer.dll
- CodeCapital.EnumerableVisualizer.pdb
- Newtonsoft.Json.dll

## Known issues
- Many I am not aware of
- A list with duplicate property name (e.g. upper/lower case issue UserId, UserID) throws an error as DataTable doesn't accept duplicate columns, this is rather rare situation, most likely bad object design

## ToDo
- Create Tests
- Add more collection types
- Save window position, height, width
- Check if there are not better DataGridView options

At the moment we can visualize these simple collections, test examples:

Example 3.1

![](https://user-images.githubusercontent.com/4528464/59273012-2dc98f80-8c4f-11e9-8a76-c11620581a3e.png)

![Example 3.1](https://user-images.githubusercontent.com/4528464/46559908-c0a87200-c8e9-11e8-83ba-deea211840f0.png)

Example 6

![Example 6](https://user-images.githubusercontent.com/4528464/46559986-fb120f00-c8e9-11e8-94d0-a03ed21d5319.png)

```c#
var list1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

var list2 = new List<string> { "Vaso", "Lena", "Helean", "Eva", "Viktoria", "Ada", "Lucia" };

var list3 = new List<Person>
{
    new Person("Vaso", 40, new Car("VW", 2017, DateTime.Now)),
    new Person("Lena", 45, new Car("Skoda", 300, DateTime.Now.AddDays(-5))),
    new Person("Phu", 20, new Car("Skoda", 3000, DateTime.Now.AddDays(-5))),
    new Person("John", 45, new Car("Skoda Subaru", 300, DateTime.Now.AddDays(-5))),
    new Person("Bob", 20, new Car("Skoda 23", 300, DateTime.Now.AddDays(-5)))
};

var list31 = new List<Person>
{
    new Person("Vaso", 40, new Car("VW", 2017, DateTime.Now, new Gadget("Phone"))),
    new Person("Lena", 45, new Car("Skoda", 300, DateTime.Now.AddDays(-5), new Gadget("Phone"))),
    new Person("Phu", 20, new Car("Skoda", 3000, DateTime.Now.AddDays(-5), new Gadget("Tv"))),
    new Person("John", 45, new Car("Skoda Subaru", 300, DateTime.Now.AddDays(-5), new Gadget("Phone"))),
    new Person("Bob", 20, new Car("Skoda 23", 300, DateTime.Now.AddDays(-5), new Gadget("Radio")))
};

var list4 = new List<Car>
{
    new Car("VW", 80),
    new Car("Skoda", 300, DateTime.Now.AddDays(0)),
    new Car("VW 2", 2018, DateTime.Now.AddDays(-10)),
    new Car("B Skoda", 300, DateTime.Now.AddDays(30)),
    new Car("8080 2018", 300, DateTime.Now.AddDays(-500))
};

var list5 = new[]
{
    new Person("Vaso", 40, new Car("VW", 80, DateTime.Now)),
    new Person("Sandy", 23, new Car("Porsche", 300, DateTime.Now.AddDays(-5)))
};

var list6 = new[]
{
    new Person("Vaso", 40, null),
    new Person("Sandy", 23, new Car("Porsche", 300, DateTime.Now.AddDays(-5)))
};

var list7 = new[]
{
    new Person { Name = "Vaso"},
    new Person()
};

var list8 = new[]
{
    new Gadget("Phone"),
    new Gadget("Radio"),
    new Gadget(""),
    new Gadget("Self Drive"),
    new Gadget("Tv")
};

var list9 = new[]
{
    new Car(new Gadget("Phone")),
    new Car(new Gadget("Radio")),
    new Car(new Gadget("")),
    new Car(new Gadget("Self Drive")),
    new Car(new Gadget("Tv"))
};
```            
