x = 0 
x_f = 0.0
b = True 
str = "hello world"

print(type(x))
print(type(x_f))
print(type(b))
print(type(str))

if x > 0:
    print("x is greater than 0")
elif x < 0:
    print("x is less than 0")
else:
    print("x is equal to 0")

if b == True:
    x += 6
    x_f += 7.0
    if str != "":
        print(f'Hello World {x} {x_f}')
    else:
        print("String is empty")

for i in range(5):
    print(f'Iteration {i}')

for i in range(len(str)):
    print(f'Character at index {i}: {str[i]}')

this_list = [1,2,3,4,5]
this_dict = {"name": "Alice", "age": 30, "city": "New York"}

tot = 0
for i in this_list:
    tot = this_list[i-1] * this_list[i-1]
print(f'Total: {tot}')

print(this_list[3:])

for i in this_dict:
    print(f'{i}: {this_dict[i]}')
for key, value in this_dict.items():
    print(f'{key}: {value}')

i = 7
while i > 0:
    x_b = x + x 
    this_list.append(x_b)
    this_list.append(x)
    if len(this_list) > 20 or tot > 10000:
        print('Big ahh list')
    else: 
        print('Small Fry')
    tot = 0 
    for j in range(len(this_list)):
        this_list[j-1] = this_list[j-1] + this_list[i-1] 
    tot = sum(this_list)
    i -= 1

print(this_list)
print(tot)

import math 
import numpy as np 
def freaky_func(x,b,str):
    if b == True:
        x = math.sqrt(x) + np.log(x)
    else: 
        x = math.sqrt(x) - np.log(x)
    if str != "":
        arr = np.array([x, x*x, x*3])
        arr1 = arr.T @ arr
    tot = arr + arr1 

    return tot, arr, arr1
print("Calling Freaky Function")        
result = freaky_func(x, b, str)
print(result)


