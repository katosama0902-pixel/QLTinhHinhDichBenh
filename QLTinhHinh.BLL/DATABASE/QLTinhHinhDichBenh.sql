CREATE DATABASE QLTinhHinh
GO
USE QLTinhHinh
GO

-- 1. Tạo bảng TrangThai
CREATE TABLE TrangThai (
    MaTT int PRIMARY KEY,
    TenTT nvarchar(100) NOT NULL,
    GhiChu nvarchar(max) NULL
)
GO

-- 2. Tạo bảng DiaPhuong
CREATE TABLE DiaPhuong (
    MaDP nvarchar(3) PRIMARY KEY, -- Đề yêu cầu Mã ĐP 3 ký tự
    TenDP nvarchar(50) NOT NULL,
    SoCaNhiemMoi int NOT NULL,
    MaTT int NOT NULL,
    FOREIGN KEY (MaTT) REFERENCES TrangThai(MaTT)
)
GO

-- 3. Thêm dữ liệu mẫu (Theo đề bài)
INSERT INTO TrangThai (MaTT, TenTT, GhiChu) VALUES 
(1, N'Bình thường', N'Không giới hạn'),
(2, N'Cách ly xã hội', N'Chỉ thị 16'),
(3, N'Khóa chặt đông cứng', NULL),
(4, N'Bình thường Mới', NULL)

INSERT INTO DiaPhuong (MaDP, TenDP, SoCaNhiemMoi, MaTT) VALUES 
(N'BDU', N'Bình Dương', 521, 4),
(N'DAK', N'DakLak', 254, 2),
(N'DON', N'Đồng Nai', 499, 3),
(N'HNO', N'Hà Nội', 0, 1),
(N'SGN', N'Tp. HCM', 1140, 4)
GO

Select * From TrangThai
Select * From DiaPhuong