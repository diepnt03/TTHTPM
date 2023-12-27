<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
				xmlns:a="http://tempuri.org/QLBenhAn.xsd"
>
	<xsl:output method="html" indent="yes"/>
	<xsl:template match="/">
		<html>
			<head>
				<title>QUản lý bệnh án</title>
			</head>
			<body>
				<xsl:for-each select="a:QLBA/a:BV">
					<h3 align="center">DANH SÁCH BỆNH NHÂN</h3>
					<xsl:for-each select="a:Khoa">
						<p>
							Tên khoa: <xsl:value-of select="a:TenKhoa"/>
						</p>
						<p>
							Trưởng khoa: <xsl:value-of select="@TruongKhoa"/>
						</p>						
						<table border="1">
							<tr>
								<td>Mã số</td>
								<td>Họ tên bệnh nhân</td>
								<td>Giới tính</td>
								<td>Số này nằm viện</td>
								<td>Tiền trả</td>
							</tr>
							<xsl:for-each select="a:BenhNhan">
								<tr>
									<td>
										<xsl:value-of select="@MaSo"/>
									</td>
									<td>
										<xsl:value-of select="a:HoTen"/>
									</td>
									<td>
										<xsl:value-of select="a:GioiTinh"/>
									</td>
									<td>
										<xsl:value-of select="a:SoNgayNamVien"/>
									</td>
									<td>
										<xsl:value-of select="a:SoNgayNamVien*60000"/>
									</td>
								</tr>
							</xsl:for-each>							
						</table>
						<p>
							Tổng tiền trả: <xsl:value-of select="sum(a:BenhNhan/a:SoNgayNamVien)*60000"/>
						</p>
						<br></br>
					</xsl:for-each>					
				</xsl:for-each>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
