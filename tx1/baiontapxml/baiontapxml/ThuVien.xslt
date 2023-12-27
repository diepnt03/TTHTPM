<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
		xmlns:a="http://tempuri.org/ThuVien.xsd"
>
	<xsl:output method="html" indent="yes"/>

	<xsl:template match="/">
		<html>
			<head>
				<title>Thư Viện</title>
			</head>
			<body>
				<xsl:for-each select="a:TV/a:NhaXB">
					<h3>
						Nhà Xuất Bản: <xsl:value-of select="@TenNXB"/>
					</h3>
					<table border="1" cellpadding="10">
						<tr>
							<td>STT</td>
							<td>Tên Sách</td>
							<td>Thể Loại</td>
							<td>Số Trang</td>
							<td>Giá</td>
						</tr>
						<xsl:for-each select="a:Sach">
							<tr>
								<td>
									<xsl:value-of select="position()"/>
								</td>
								<td>
									<xsl:value-of select="a:TenSach"/>
								</td>
								<td>
									<xsl:value-of select="a:TheLoai"/>
								</td>
								<td>
									<xsl:value-of select="a:SoTrang"/>
								</td>
								<td>
									<!--tương tự như switch--> 
									<xsl:choose>
										<xsl:when test="a:SoTrang &lt; 100">  <!--&lt; : <-->
											<xsl:value-of select="a:SoTrang*4000"/>
										</xsl:when>
										<xsl:when test="SoTrang &lt; 150">
											<xsl:value-of select="100*4000+a:SoTrang*3000-100*3000"/>
										</xsl:when>
										<xsl:otherwise>
											<xsl:value-of select="100*4000+50*3000+a:SoTrang*2000-150*2000"/>
										</xsl:otherwise>
									</xsl:choose>
								</td>
							</tr>
						</xsl:for-each>
					</table>
				</xsl:for-each>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
