def main():
    myPrevious = 1
    myNext = 2
    mySum = 0
    while True:
        if (myNext > 4000000):
            break

        if (myNext % 2 == 0):
            mySum = mySum + myNext
        
        myPrevious, myNext = myNext, myPrevious
        myNext = myPrevious + myNext

    print(mySum)

    return mySum

if __name__ == "__main__":
    main()




