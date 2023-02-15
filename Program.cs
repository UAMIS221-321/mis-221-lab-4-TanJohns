// start mian    

int userInput = GetUserChoice();

static int GetUserChoice(){
    GetMenu();
    string userInput=Console.ReadLine();
    if(IsValidChoice(userInput)){
        return int.Parse(userInput);
    }
    else return 0;
}

static void GetMenu(){
    Console.Clear();
    Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit ");

}

static bool IsValidChoice(string userInput){
    if(userInput=="1" || userInput=="2" || userInput=="3"){
        return true;
    }
    else return false;
}

static void GetFull(){
  int num1 = 1; 
    for(int row = 1; row <= 9; row++){
        for (int col = 1; col <= row; col++){
        Console.Write("*");
        num1++;
        }   
        Console.WriteLine();
    }
    Console.ReadLine();
    PauseAction();
}


 static void GetPartial(){
    int num2 = 1;
    for(int row = 1; row <= 9; row++){ 
        for(int col = 1; col <= row; col++){ 
            Console.Write("*");
             num2++;
        }
        Console.WriteLine();
    }
    Console.ReadLine();
    PauseAction();
}

static void IsInvalid(){
    Console.WriteLine("Invalid");
    PauseAction();
}

    if (userInput==1){
        GetFull();
    }
    else if (userInput==2){
        GetPartial();
    }
    else if(userInput!=3){
        IsInvalid();
    }

static void PauseAction(){
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}


