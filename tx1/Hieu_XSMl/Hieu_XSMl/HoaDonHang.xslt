<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
		<html>
			<head>
				<title>Danh mục hoá đơn</title>
				
			</head>
			<body>
				<h2>PHIẾU MUA HÀNG</h2>
				<table border="0">
					<tr>
						<td>
							Hoá đơn : <xsl:value-of select="DS/HoaDon/MaHD"/>
						</td>
						<td>
							Hoá đơn : <xsl:value-of select="DS/HoaDon/NgayBan"/>
						</td>
					</tr>
					<tr>
						<td>
							Loại Hàng: <xsl:value-of select="DS/HoaDon/LoaiHang/@TenLoai"/>
						</td>
					</tr>
				</table>
				<table border="2" cellpadding="3">
					<tr>
						<td>Mã Hàng</td>
						<td>Tên Hàng</td>
						<td>Số Lượng</td>
						<td>Đơn Giá</td>
						<td>Thành Tiền</td>
					</tr>
					<xsl:for-each select="DS/HoaDon/LoaiHang/Hang">
						<xsl:if test="SoLuong>60">
							<tr>
							<td>
								<xsl:value-of select="@MaHang"/>
								
							</td>
							<td>
								<xsl:value-of select="TenHang"/>
								
							</td>
							<td>
								<xsl:value-of select="SoLuong"/>
								
							</td>
							<td>
								<xsl:value-of select="DonGia"/>
								
							</td>
							<td>
								<xsl:value-of select="DonGia*SoLuong"/>
								
							</td>
						</tr>
						</xsl:if>
						
					</xsl:for-each>
				</table>
			</body>
		</html>
    </xsl:template>
</xsl:stylesheet>
