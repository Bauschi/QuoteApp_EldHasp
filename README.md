# QuoteApp_EldHasp

Hello EldHasp, 
This is my scatch if you try to run it, please change Line 33 of Word.cs as i was unable to assign a relative path to open to word template.
I would be very happy, if you could show me how to set the path to relative. I spend about 2 hours but nothing worked. 

This scatch works perfect for me and i know that this has nothing to do with MVVM Pattern.
In my opinion a design Pattern is very important when working in a big team eg. but in this case a quick solution is what i need. 

I talked to my colleague about this Topic and he also said, that he is working like my solution. 
I have read a lot about MVVM and don't see how this should be useful for our purposes. 

The initial question was: How to get access to an Object created on WPF Level like here: 

```xml

    <Window.Resources>
         Binding the Data Class
        <local:Cl_Data x:Key="Data" 
                       Dealer="Test"
                       Costumer="Tester"
                       Machine="+++++"
                       PRJ="123456"
                       DeliveryTime="6"
                       Description="Managin+++++++++nsor for chuck clamp unclamp position"
                       Operation="The operator can selec++++++++++++++++++++++++++++++++++++or next time"
                       FunctionName="GeneratorAPP"
                       Requirements="A++-Kit"
                       />
    </Window.Resources>
    
 ```

But the answer on this type is or would be : It is not possible to access data created in this context. 
With MvvM it is not necessary to access the object from any other class.
In my approach wich is much easier for me in the beginning i want to access the instance of the object Data for easily accessing the properties and work with them 
please see in my Solution how i managaed it. 

``` cs

 public static Cl_Data Data = new Cl_Data();

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = Data;
        }

```


The big difference between our Solutions is, that i bind the DataContext in MainWindow.cs (CodeBehind) to a Class and create a specific Instance of the Object which i access from every other class. Thats much more understandable for me so far. 

SO please point out if i am wrong in my thinking and what i can improve and if you agree with my statements 
