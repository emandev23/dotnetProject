# EBookStore - Online Book Shopping Application

A modern, feature-rich online bookstore built with ASP.NET Core MVC. EBookStore provides a seamless shopping experience for book lovers and an efficient management system for administrators.

## 🌟 Features

### For Customers
- **Browse Books**: Explore a wide selection of books with detailed information
- **Search & Filter**: Find books by title, author, or genre
- **Shopping Cart**: Add books to cart, manage quantities, and checkout
- **Order Management**: Track order status and view order history
- **User Accounts**: Register, login, and manage personal profile
- **Responsive Design**: Seamless experience across all devices

### For Administrators
- **Book Management**: Add, edit, and remove books from the catalog
- **Inventory Control**: Track and manage book stock levels
- **Order Processing**: View and manage customer orders
- **User Management**: Manage user accounts and roles

## 🎨 UI Features
- Modern and clean interface
- Primary color: #4F46E5 (Indigo)
- Secondary color: #6B7280 (Gray)
- Custom SVG illustrations for empty states
- Bootstrap-based responsive design
- Intuitive navigation and user flow

## 🛠️ Technical Stack
- **Framework**: ASP.NET Core MVC
- **Database**: Entity Framework Core
- **Frontend**: 
  - HTML5, CSS3, JavaScript
  - Bootstrap 5
  - Bootstrap Icons
- **Authentication**: ASP.NET Core Identity
- **Payment**: Cash on Delivery (COD)

## 📱 Responsive Design
- Mobile-first approach
- Adaptive layouts for all screen sizes
- Touch-friendly interface elements
- Optimized images and assets

## 🔒 Security Features
- Secure user authentication
- Role-based authorization
- Password hashing
- CSRF protection
- Secure session management

## 💼 Business Features
- Inventory management
- Order processing workflow
- User role management (Admin/Customer)
- Email notifications (configurable)

## 🚀 Getting Started

### Prerequisites
- .NET 6.0 SDK or later
- SQL Server
- Visual Studio 2022 (recommended) or VS Code

### Installation Steps
1. Clone the repository
2. Update the connection string in `appsettings.json`
3. Open terminal in project directory
4. Run Entity Framework migrations:
   ```bash
   dotnet ef database update
   ```
5. Run the application:
   ```bash
   dotnet run
   ```
6. Access the application at `https://localhost:5001`

### Default Admin Account
- Username: admin@ebookstore.com
- Password: Admin123!

## 📸 Screenshots
[Screenshots will be added showing key features of the application]

## 🤝 Contributing
Contributions are welcome! Please feel free to submit a Pull Request.

## 📄 License
This project is licensed under the MIT License - see the LICENSE file for details.

## 🙏 Acknowledgments
- Bootstrap for the UI framework
- Bootstrap Icons for the icon set
- ASP.NET Core team for the amazing framework
