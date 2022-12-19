number = int(input('Введите число:'))
number = abs(number)
negative = number*-1
while negative < number:
    print(f"{negative}, ")
    negative=negative+1
else:
    print(number)