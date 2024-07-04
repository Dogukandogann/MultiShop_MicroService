<h1>MultiShop E-Ticaret</h1>

<h2>Açıklama</h2>
<p>Bu proje, çeşitli mikroservislerin bir araya gelmesiyle oluşturulmuş bir e-ticaret sitesi projesidir. Kullanıcılar, bu platform üzerinden çeşitli özellikleri kullanarak alışveriş yapabilirler.</p>

<h2>Kullanıcı Özellikleri</h2>
<ul>
    <li><strong>Kayıt ve Giriş:</strong> Kullanıcılar kayıt olup giriş yapabilirler.</li>
    <li><strong>Ürün Gezinme:</strong> Ürünler arasında gezebilir, kategorilere ve ürün özelliklerine göre ürünleri listeleyebilirler.</li>
    <li><strong>Sipariş Verme:</strong> İndirim kuponu kullanarak, fatura ve kart bilgilerini doldurduktan sonra siparişlerini verebilirler.</li>
    <li><strong>Kargo Seçenekleri:</strong> Anlaşmalı kargo firmaları ile ürünlerini satın alabilirler.</li>
    <li><strong>Kullanıcı Paneli:</strong> Aktif ve geçmiş siparişleri, kargoları ve profil bilgilerini görüntüleyebilirler. Ayrıca site yöneticilerine direkt mesaj gönderebilirler.</li>
</ul>

<h2>Yönetici Özellikleri</h2>
<ul>
    <li><strong>Yönetici Paneli:</strong> Site yöneticileri, ürün, kategori, kargo firması, marka ve indirim kuponu ekleyebilir, kullanıcılardan gelen mesajları okuyabilir ve yanıtlayabilirler.</li>
    <li><strong>Ürün Resimleri:</strong> Google Cloud kullanarak ürün resimlerini saklayabilirler.</li>
    <li><strong>Canlı İstatistikler:</strong> SignalR yardımıyla site istatistiklerini canlı olarak görebilirler.</li>
</ul>

<h2>Servisler</h2>

<h3>Katalog Servis</h3>
<p>Ürünleri ve kategorileri barındıran, MongoDB kullanan API servisidir.</p>

<h3>İndirim Servis</h3>
<p>İndirim kuponlarını barındıran, MS SQL veritabanı kullanan API servisidir.</p>

<h3>Sipariş Servis</h3>
<p>Siparişleri barındıran, Onion Architecture & CQRS Mediator tasarım desenleri ile oluşturulmuş, MS SQL veritabanı kullanan API servisidir.</p>

<h3>Identity Servis</h3>
<p>Kimlik doğrulama ve rol bazlı yetkilendirme işlemleri için IdentityServer 4, OAuth2, JSON Web Token kullanan, MS SQL veritabanı kullanan API servisidir.</p>

<h3>Kargo Servis</h3>
<p>Kargo işlemlerini yöneten, MS SQL veritabanı kullanan API servisidir.</p>

<h3>Sepet Servis</h3>
<p>Sepet işlemlerini yöneten, Redis veritabanı kullanan API servisidir.</p>

<h3>Yorum Servis</h3>
<p>Kullanıcıların yorumlarını yöneten, MS SQL veritabanı kullanan API servisidir.</p>

<h3>API Gateway Servis</h3>
<p>Gelen istekleri yönlendiren, yetkilendiren, güvenlik politikalarını uygulayan, yük dengelemesi yapan ve uygun mikroservislere yönlendiren Ocelot API servisidir.</p>

<h3>Mesaj Servis</h3>
<p>Kullanıcıların mesaj gönderme işlemlerini yöneten, PostgreSQL veritabanı kullanan API servisidir.</p>

<h3>Resim Servis</h3>
<p>Google Cloud Storage altyapısını kullanarak resimleri yönetmekle görevli servistir.</p>

<h2>Teknolojiler</h2>
<ul>
    <li><strong>Geliştirme Ortamı:</strong> Visual Studio 2022</li>
    <li><strong>Kod Altyapısı:</strong> C#, ASP.NET MVC, .NET CORE 7, Web API</li>
    <li><strong>Mimari Tasarım:</strong> N-Tier Katmanlı Mimari, Onion Mimari</li>
    <li><strong>Veri Tabanı:</strong> MS SQL Server, MongoDB, PostgreSQL, Redis</li>
    <li><strong>Veri Erişim Teknolojisi:</strong> Entity Framework CORE (CodeFirst), LINQ</li>
    <li><strong>Arayüz Tasarımı:</strong> HTML5, CSS3, JavaScript, jQuery, Ajax, Bootstrap</li>
    <li><strong>Diğer Özellikler:</strong> DTO, ViewModel, AutoMapper, FluentValidation, Microsoft Identity, Partial Views, View Components, Repository Design Pattern, Dependency Injection, RabbitMQ Library, CQRS, MediatR Design Pattern, SignalR, Localization, Mailkit, MimeKit</li>
    <li><strong>Versiyon Kontrol Sistemi:</strong> Git</li>
    <li><strong>Altyapı ve Dağıtım Araçları:</strong> Docker, Google Cloud</li>
</ul>

<h1>English</h1>

<h1>MultiShop E-Commerce</h1>

<h2>Description</h2>
<p>This project is an e-commerce website created by integrating various microservices. Users can shop on this platform using various features.</p>

<h2>User Features</h2>
<ul>
    <li><strong>Registration and Login:</strong> Users can register and log in.</li>
    <li><strong>Product Browsing:</strong> Users can browse products and list them by categories and product features.</li>
    <li><strong>Placing Orders:</strong> Users can place orders by filling in their billing and card details and applying discount coupons if available.</li>
    <li><strong>Shipping Options:</strong> Users can purchase products with partnered shipping companies.</li>
    <li><strong>User Panel:</strong> Users can view their active and past orders, shipments, and profile details. They can also send direct messages to site administrators.</li>
</ul>

<h2>Admin Features</h2>
<ul>
    <li><strong>Admin Panel:</strong> Site administrators can add products, categories, shipping companies, brands, and discount coupons. They can also read and respond to messages from users.</li>
    <li><strong>Product Images:</strong> Product images can be stored using Google Cloud.</li>
    <li><strong>Live Statistics:</strong> Site administrators can view live site statistics using SignalR.</li>
</ul>

<h2>Services</h2>

<h3>Catalog Service</h3>
<p>An API service using MongoDB to manage products and categories.</p>

<h3>Discount Service</h3>
<p>An API service using MS SQL database to manage discount coupons.</p>

<h3>Order Service</h3>
<p>An API service using MS SQL database to manage orders, built with Onion Architecture & CQRS Mediator design patterns.</p>

<h3>Identity Service</h3>
<p>An API service using MS SQL database for authentication and role-based authorization, utilizing IdentityServer 4, OAuth2, and JSON Web Token.</p>

<h3>Cargo Service</h3>
<p>An API service using MS SQL database to manage shipping processes.</p>

<h3>Basket Service</h3>
<p>An API service using Redis database to manage shopping cart processes.</p>

<h3>Review Service</h3>
<p>An API service using MS SQL database to manage user reviews.</p>

<h3>API Gateway Service</h3>
<p>An Ocelot API service that routes incoming requests, authorizes them, applies security policies, balances the load, and directs requests to appropriate microservices.</p>

<h3>Message Service</h3>
<p>An API service using PostgreSQL database to manage user messaging processes.</p>

<h3>Image Service</h3>
<p>A service responsible for managing images using Google Cloud Storage infrastructure.</p>

<h2>Technologies</h2>
<ul>
    <li><strong>Development Environment:</strong> Visual Studio 2022</li>
    <li><strong>Code Base:</strong> C#, ASP.NET MVC, .NET CORE 7, Web API</li>
    <li><strong>Architectural Design:</strong> N-Tier Architecture, Onion Architecture</li>
    <li><strong>Database:</strong> MS SQL Server, MongoDB, PostgreSQL, Redis</li>
    <li><strong>Data Access Technology:</strong> Entity Framework CORE (CodeFirst), LINQ</li>
    <li><strong>Frontend Design:</strong> HTML5, CSS3, JavaScript, jQuery, Ajax, Bootstrap</li>
    <li><strong>Other Features:</strong> DTO, ViewModel, AutoMapper, FluentValidation, Microsoft Identity, Partial Views, View Components, Repository Design Pattern, Dependency Injection, RabbitMQ Library, CQRS, MediatR Design Pattern, SignalR, Localization, Mailkit, MimeKit</li>
    <li><strong>Version Control System:</strong> Git</li>
    <li><strong>Infrastructure and Deployment Tools:</strong> Docker, Goo

<h1>Resimler/Images</h1>

![Login](https://github.com/Dogukandogann/MultiShop_MicroService/assets/134203440/7c74973e-9a28-4b1e-9c9b-8776d5d30135)
![AnaSayfa](https://github.com/Dogukandogann/MultiShop_MicroService/assets/134203440/f9e13ddd-e37d-4f72-a83d-1be6bdf16b49)
![ürün](https://github.com/Dogukandogann/MultiShop_MicroService/assets/134203440/3f6911a0-6512-48e4-9590-acccebbcabe5)
![contact](https://github.com/Dogukandogann/MultiShop_MicroService/assets/134203440/211cc2fb-a197-4558-8757-82f2e8c86937)
![Sepet](https://github.com/Dogukandogann/MultiShop_MicroService/assets/134203440/0596a8fe-8e36-4431-8e46-23a3030a43a9)
![Ödeme](https://github.com/Dogukandogann/MultiShop_MicroService/assets/134203440/6d1d7c93-d6fb-4404-9f5b-521bc07027e0)
![siparis](https://github.com/Dogukandogann/MultiShop_MicroService/assets/134203440/731fe6eb-5ebe-4d50-8b55-a44123550956)
![Marka](https://github.com/Dogukandogann/MultiShop_MicroService/assets/134203440/20e4663f-7023-463d-a44e-edc1c11f0de3)
![Kategori](https://github.com/Dogukandogann/MultiShop_MicroService/assets/134203440/f5224e8b-4fea-44ce-9217-c27d58889cd0)
![istatistic](https://github.com/Dogukandogann/MultiShop_MicroService/assets/134203440/c74766dc-55b3-4a77-8572-6a5af5629f83)
![Localization](https://github.com/Dogukandogann/MultiShop_MicroService/assets/134203440/0c774776-7f3c-48ac-bc86-40d0bd7bf6f5)
![Docker](https://github.com/Dogukandogann/MultiShop_MicroService/assets/134203440/2dd2761c-6633-4ff4-a083-cf39ed6dceea)

