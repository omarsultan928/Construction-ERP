# **Construction ERP MVP Requirements**

## **Project Goal**

Develop a simple MVP construction management and job cost tracking system for internal company use.

Primary users:

* Admin  
* Accountant  
* Project Manager

---

# **MODULE 1 — Authentication & User Management**

## **Epic**

As a company employee, I want secure access to the system so that only authorized users can manage construction projects and financial data.

---

## **User Stories**

### **US-1: User Login**

As a system user

I want to log into the application

So that I can access the system securely.

### **Acceptance Criteria**

* User can enter email and password  
* Invalid credentials show error  
* Successful login redirects to dashboard  
* Session/token is maintained

---

### **US-2: Role-Based Access**

As an admin

I want different users to have different permissions

So that sensitive operations are restricted.

### **Roles**

* Admin  
* Accountant  
* Project Manager

### **Acceptance Criteria**

* Only admins can manage users  
* Accountants can manage invoices/expenses  
* Project managers can manage projects

---

### **US-3: User Management**

As an admin

I want to create and manage users

So that employees can access the system.

### **Acceptance Criteria**

* Create user  
* Edit user  
* Disable user  
* Assign role

---

# **MODULE 2 — Project / Job Management**

## **Epic**

As a project manager, I want to manage construction projects so that project costs and billing can be tracked properly.

---

## **User Stories**

### **US-4: Create Project**

As a project manager

I want to create a new project/job

So that project-related costs can be tracked.

### **Fields**

* Project code  
* Project name  
* Client name  
* Budget amount  
* Start date  
* End date  
* Status

### **Acceptance Criteria**

* Required fields validated  
* Unique project code  
* Project saved successfully

---

### **US-5: View Project List**

As a system user

I want to see all projects

So that I can monitor ongoing work.

### **Acceptance Criteria**

* Search projects  
* Filter by status  
* Sort by date/name

---

### **US-6: Project Details Dashboard**

As a project manager

I want to see project summary information

So that I can monitor budget and progress.

### **Dashboard Info**

* Total expenses  
* Remaining budget  
* Invoice totals  
* Profit/loss estimate

---

# **MODULE 3 — Expense & Job Cost Tracking**

## **Epic**

As an accountant, I want to record project expenses so that actual project costs can be monitored.

---

## **User Stories**

### **US-7: Add Project Expense**

As an accountant

I want to add expenses against a project

So that project cost is accurately tracked.

### **Expense Categories**

* Labor  
* Material  
* Equipment  
* Subcontractor  
* Miscellaneous

### **Acceptance Criteria**

* Expense linked to project  
* Amount required  
* Date required  
* Category required

---

### **US-8: View Expense Summary**

As a project manager

I want to see expense summaries by category

So that I can analyze project spending.

### **Acceptance Criteria**

* Category-wise totals  
* Total project cost  
* Budget vs actual comparison

---

### **US-9: Edit/Delete Expense**

As an accountant

I want to update incorrect expense records

So that financial data stays accurate.

### **Acceptance Criteria**

* Expense can be edited  
* Expense can be deleted  
* Audit log optional for MVP

---

# **MODULE 4 — Vendor / Subcontractor Management**

## **Epic**

As a company user, I want to manage vendors and subcontractors so that payments and project relationships are organized.

---

## **User Stories**

### **US-10: Create Vendor**

As an accountant

I want to register vendors/subcontractors

So that vendor information is centrally managed.

### **Fields**

* Vendor name  
* Contact person  
* Phone  
* Email  
* Vendor type

---

### **US-11: Assign Vendor to Project**

As a project manager

I want to associate vendors with projects

So that subcontractor work can be tracked.

---

### **US-12: Track Vendor Payments**

As an accountant

I want to track vendor payment status

So that unpaid balances are visible.

### **Statuses**

* Pending  
* Partial  
* Paid

---

# **MODULE 5 — Invoice & Billing**

## **Epic**

As an accountant, I want to generate invoices for projects so that the company can track receivables.

---

## **User Stories**

### **US-13: Create Invoice**

As an accountant

I want to create project invoices

So that clients can be billed.

### **Fields**

* Invoice number  
* Project  
* Amount  
* Invoice date  
* Due date  
* Notes

---

### **US-14: Update Invoice Status**

As an accountant

I want to update invoice payment status

So that outstanding payments are tracked.

### **Statuses**

* Draft  
* Sent  
* Paid  
* Overdue

---

### **US-15: View Outstanding Invoices**

As an accountant

I want to see unpaid invoices

So that I can follow up with clients.

---

# **MODULE 6 — Dashboard & Reporting**

## **Epic**

As a management user, I want dashboards and reports so that I can monitor business performance.

---

## **User Stories**

### **US-16: Dashboard Overview**

As a management user

I want to view key business metrics

So that I can quickly understand company performance.

### **Widgets**

* Active projects  
* Total expenses  
* Outstanding invoices  
* Profit/loss summary

---

### **US-17: Budget vs Actual Report**

As a project manager

I want to compare budget and actual cost

So that I can identify overspending.

---

### **US-18: Project Profitability Report**

As a management user

I want to view estimated project profit/loss

So that I can evaluate project performance.

### **Formula**

Profit \= Invoice Amount − Total Expenses

---

# **Non-Functional Requirements**

## **Performance**

* Pages should load within 3 seconds  
* Dashboard should support at least 100 projects

---

## **Security**

* Password hashing  
* JWT/session authentication  
* Role-based authorization

---

## **Usability**

* Responsive UI  
* Simple navigation  
* Basic form validation

---

## **Reliability**

* Prevent duplicate project codes  
* Prevent invalid expense amounts