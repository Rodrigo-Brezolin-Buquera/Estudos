# indice negativo pela de traz pra frente


# bubblesort em array

my_list = [8, 10, 6, 2, 4]  # Lista para ordenar
swapped = True  # É um pouco falso, precisamos dele para entrar no loop while.
 
while swapped:
    swapped = False  # nenhuma troca até agora
    for i in range(len(my_list) - 1):
        if my_list[i] > my_list[i + 1]:
            swapped = True  # uma troca ocorreu!
            my_list[i], my_list[i + 1] = my_list[i + 1], my_list[i]
 
# print(my_list)


#copia de array
list_1 = [1]
list_2 = list_1[:]
list_1[0] = 2
# print(list_2)

my_list = [10, 8, 6, 4, 2]
new_list = my_list[1:3] # intervalo de itens
# my_list[1:]
# my_list[1:-1]
# print(new_list)

# del my_list[:]


# in e not in
# print(5 in my_list)
# print(5 not in my_list)
# print(12 in my_list)



# tuplas - lista imutavel

tuple_1 = (1, 2, 4, 8)
tuple_2 = 1., .5, .25, .125

# O que mais as tuplas podem fazer por você?

# a função len() aceita tuplas e retorna o número de elementos contidos nela;
# o operador + pode unir as tuplas (já mostramos isso)
# o operador * pode multiplicar tuplas, assim como listas;
# os operadores in e not in funcionam da mesma forma que nas listas.

# mutiplicação

test = [1,3,4]*5
print(test)


# dicionario aka hashtable

dictionary = {"gato": "chat", "cachorro": "chien", "cavalo": "cheval"}
print(dictionary['gato'])

sorted()
dictionary.keys()
dictionary['swan'] = 'cygne'
del dictionary['cachorro']

