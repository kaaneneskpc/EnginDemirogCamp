title = 'İlginizi Çekebilir'
expiry = 48
bankrate = 1.69

print('Title : ' + title)
print(expiry)
print(bankrate)

print(type(bankrate))
print(type(expiry))       #type = datatype
print(type(title))

# ---------------------------  Conditionals ------------------------------

dollarOld = 7.35
dollarNew = 7.45

if(dollarOld>dollarNew):
    print("Down")
elif(dollarOld<dollarNew):
    print("Up")
elif(dollarOld==dollarNew):
    print("Not Change")
    

#------------------------------Arrays----------------------------------------

credits = ["Fast Credit","Salary","Happy Retired"]

for credit in credits:
    print("Options : " + credit)      
    
    
#---------------------------- Functions --------------------------------------

def listCredits():
    
    credits = ["Fast Credit","Salary","Happy Retired"]
    for credit in credits:
        print("Options : " + credit)  

listCredits()                     