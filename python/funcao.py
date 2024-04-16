# burlando escopos

def my_function():
 global var
 var = 2
 print("Eu conheço aquela variável?", var)


var = 1
my_function()
print(var)