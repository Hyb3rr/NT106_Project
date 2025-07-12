# 🎯 QUICK START GUIDE - For Teachers

## 📋 Project: BookReader Network Application
**Course:** Network Programming (NT106)  
**GitHub:** https://github.com/Hyb3rr/NT106_Project  
**Branch:** new_BE

---

## 🚀 1-MINUTE DEMO

### Step 1: Download & Extract
```bash
# Download ZIP from GitHub or clone:
git clone https://github.com/Hyb3rr/NT106_Project.git
cd NT106_Project
```

### Step 2: Run Demo (ONE COMMAND)
```bash
# Open Command Prompt in project folder:
demo_load_balancing.bat
```

### Step 3: What You'll See
- **5 Windows** will open:
  - Server 1 (Port 8081)
  - Server 2 (Port 8082)  
  - Load Balancer (Port 8080)
  - Client 1, 2, 3 (Login screens)

---

## ✅ QUICK VERIFICATION

### Check Requirements (30 seconds each):

| Requirement | How to Verify | Expected Result |
|-------------|---------------|-----------------|
| **App + Socket** | See `SocketService.cs` line 10 | ✅ TCP client integrated |
| **Multi Client** | Server console shows | ✅ "3 clients connected" |
| **Multi Server** | 2 server windows running | ✅ Port 8081, 8082 |
| **Demo LAN** | Server binds 0.0.0.0 | ✅ Accessible from LAN |
| **Load Balancing** | Load Balancer console | ✅ Routing messages |
| **Demo Internet** | `demo_internet.bat` | ✅ Ngrok public URL |
| **Deploy** | `deploy_railway.bat` | ✅ Docker + Cloud ready |

---

## 🎭 DEMO SCENARIOS

### Scenario 1: Basic Demo (3 minutes)
```bash
demo_load_balancing.bat
```
1. Wait for 5 windows to open
2. Login different users in 3 clients
3. Add book in Client 1 → see notification in Client 2,3
4. **DONE!** ✅

### Scenario 2: Internet Demo (2 minutes)
```bash
demo_internet.bat
```
*Requires ngrok for public access*

---

## 🔧 REQUIREMENTS

- **Windows 10/11**
- **.NET 8.0 SDK** ([Download](https://dotnet.microsoft.com/download/dotnet/8.0))

Check: `dotnet --version` → Should show 8.0.x

---

## 🏆 TEST ACCOUNTS

```
admin / admin123     (Admin)
user1 / user123      (User)  
user2 / user123      (User)
```

---

## 🚨 IF SOMETHING GOES WRONG

```bash
# Reset everything:
clean_project.bat

# Then try again:
demo_load_balancing.bat
```

---

## 📊 GRADING CHECKLIST

- [✅] App + Socket logic → **1 point**
- [✅] Multi Client → **1 point**
- [✅] Multi Server → **1 point**
- [✅] Demo LAN → **1 point**
- [✅] Load Balancing → **1 point**
- [✅] Demo Internet → **1 point**
- [✅] Deploy → **1 point**

**Total: 7/7 points (100%)**

---

## 🎉 THAT'S IT!

**Project is complete and ready for evaluation!** 🚀

*For detailed instructions, see `HUONG_DAN_SU_DUNG.md`*
