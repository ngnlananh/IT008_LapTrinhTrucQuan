CREATE DATABASE QuanLySinhVien;
GO

USE QuanLySinhVien;

CREATE TABLE SINHVIEN (
    MSSV INT PRIMARY KEY,
    TEN NVARCHAR(100) NOT NULL,
    KHOA INT NOT NULL,       
    DIEMTB FLOAT
    CONSTRAINT FK_SV_KHOA FOREIGN KEY(KHOA) REFERENCES KHOA(MAKHOA)
);
CREATE TABLE KHOA (
    MAKHOA INT PRIMARY KEY,
    TENKHOA NVARCHAR(100) NOT NULL
);

INSERT INTO KHOA (MaKhoa, TenKhoa)
VALUES
(1,N'Công nghệ Phần mềm'),
(2,N'Khoa học dữ liệu'),
(3,N'Kỹ thuật máy tính'),
(4,N'Trí tuệ nhân tạo'),
(5,N'Khoa học máy tính'),
(6,N'An toàn thông tin')
SELECT * FROM KHOA
INSERT INTO SINHVIEN (MSSV, Ten, Khoa, DiemTB)
VALUES
(1, N'Nguyễn Văn A', 4, 8.2),
(2, N'Trần Thị B', 5, 7.5),
(3, N'Nguyễn Lê Đức Huy', 1, 9.5),
(4, N'Nguyễn Ngọc Lan Anh', 6, 9.12),
(5, N'Nguyễn Chí Nguyên',2, 9.6),
(6, N'Đào Thị Mai Chi', 3, 7.2),
(7, N'Vũ Quỳnh Anh', 1, 7.0)

SELECT * FROM SINHVIEN