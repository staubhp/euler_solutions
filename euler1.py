def main():
    mySum = 0

    for x in range (0,1000):
        if x%3==0 or x%5==0:
            mySum = mySum + x

    print(mySum)
    return mySum

if __name__ == "__main__":
    main()
