//Wagoner knows about the issues I had with git, code written with Sean Wiles
const double MERCHANT_FLAT_FEE = 5.27;
const double COST_OF_SPELL = 10.0;
const double COST_OF_MAGIC_INGREDIENT = .25;

double numberOfSpells = 0.0;
double numberOfMagicIngredients = 0.0;
double offerings = 0.0;

Console.WriteLine("Enter the number of spells.");
numberOfSpells = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the number of ingredients.");
numberOfMagicIngredients = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the number of offerings.");
offerings = double.Parse(Console.ReadLine());

double totalSpellCost = COST_OF_SPELL * numberOfSpells;
double totalIngredientCost = COST_OF_MAGIC_INGREDIENT * numberOfMagicIngredients;
double totalMerchantPayment = MERCHANT_FLAT_FEE + offerings;
double goldOwed = totalSpellCost + totalIngredientCost + totalMerchantPayment;

Console.WriteLine(goldOwed);