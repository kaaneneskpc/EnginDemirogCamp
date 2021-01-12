print("Welcome.Please Login")

sys_username = "Kaan"
sys_password = "1234"

username = input("Enter Username: ")
password = input("Enter password : ")

if (username== sys_username) and (password != sys_password):
    print("Password Wrong")

elif (username != sys_username) and (password == sys_password):
    print("Username Wrong")

elif (username != sys_username) and (password != sys_password):
    print("Username and Password wrong")
else:
    print("Login Successfull!")
    

def creditList():
    
    yourcredits = ["Fast Credit","Salary","Happy Retired"]
    for yourcredit in yourcredits:
        print("Your Credits : " + yourcredit)

creditList()            