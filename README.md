# Blazor Google Auth

Blazor Web App ini menggunakan **Google OAuth 2.0** untuk autentikasi pengguna. Proyek dibangun dengan Blazor Server dan ASP.NET Core, memanfaatkan middleware `AddAuthentication()` dan integrasi `AddGoogle()`.

## 🚀 Fitur

- Login menggunakan akun Google
- Menggunakan cookie-based authentication
- Pemisahan konfigurasi rahasia via `appsettings.Development.json` atau `User Secrets`
- Struktur yang bersih dan scalable

---

## 🛠️ Setup dan Konfigurasi

### 1. Clone Repository

```bash
git clone https://github.com/azizp2/BlazorGoogleAuth.git
cd BlazorGoogleAuth
