import math
"""
This problem can be solved using the Sieve of Eratosthenes
(http://en.wikipedia.org/wiki/Sieve_of_Eratosthenes)
"""

def main():    
#    myProvidedValue = input('Please enter an integer value:')
    myProvidedValue = 600851475143


    myProvidedValue = int(math.sqrt(myProvidedValue))


#first we make a list of all integers from 2 to myProvidedValue
    myList = list(range(2, myProvidedValue))


#now we use the Sieve algorithm to collect all of the prime numbers in myList
    p = 2
    while True:
        if math.pow(p,2) > myProvidedValue :
            break

        myTempList = myList
        for y in myTempList:
            if y > p:
                if y % p == 0:
                    myList.remove(y)

        q=p

        for z in myList:
            if z > p:
                p = z
                break            

        if q == p:
            break
        
#myList now contains only prime numbers
    print(myList[len(myList)-1])


if __name__ == "__main__":
    main()

