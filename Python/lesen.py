
def dividers():
    n = int(input('ввидите число: '))

    for divider in range(1, n+1):
        if n % divider == 0 :
            if divider % 2 == 0:
                print(f'{divider} - четный')
            else:
                print(f'{divider} - нечетный')

# dividers()

for x in range(2):
    for y in range(2):
        print(f'{x} | {y} | {int(not x or y)}')
