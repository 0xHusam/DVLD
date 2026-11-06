## 🚀 Getting Started

To get a local copy of the DVLD project up and running, follow these steps.

### Prerequisites
Ensure you have the following installed on your local machine:
* **Visual Studio** (with .NET Desktop Development workload)
* **Microsoft SQL Server**
* **SQL Server Management Studio (SSMS)**

### Installation & Setup

**1. Clone the repository**
Open your terminal or command prompt and run:
`git clone https://github.com/0xHusam/DVLD.git`

**2. Setup the Database**
* Open **SQL Server Management Studio (SSMS)** and connect to your local database engine.
* Go to `File` > `Open` > `File...` and locate the `DVLD_Database.sql` script included in this repository.
* Click **Execute (F5)** to generate the database schema, tables, and insert the default data.

**3. Configure the Connection String**
* Open the solution file (`.sln`) in **Visual Studio**.
* Navigate to your Data Access Layer classes or the configuration file (`App.config` / `Settings`).
* Verify that the connection string points to your local server. It should look like this:
  `Server=.;Database=DVLD;Integrated Security=True;`

**4. Build and Run**
* Right-click on the main Windows Forms project in the Solution Explorer and select **Set as Startup Project**.
* Press **F5** or click **Start** to compile and run the application.
