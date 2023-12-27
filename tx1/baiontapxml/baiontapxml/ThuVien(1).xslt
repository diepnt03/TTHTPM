<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="TV">
		<html>
			<head>
				<title>Thư Viện</title>
			</head>
			<body>
				<xsl:apply-templates select="NhaXB" />
			</body>
	    </html>
    </xsl:template>
	<xsl:template match="NhaXB">
		<h3>Nhà Xuất Bản: <xsl:value-of select="@TenNXB"/></h3>
		<table border="1" cellpadding="10">
			<tr>
				<td>STT</td>
				<td>Tên Sách</td>
				<td>Thể Loại</td>
				<td>Số Trang</td>
				<td>Giá</td>
			</tr>
			<xsl:apply-templates select="Sach"/>
			
		</table>
	</xsl:template>
	<xsl:template match="Sach">
		<tr>
			<td>
				<xsl:value-of select="position()"/>
			</td>
			<td>
				<xsl:value-of select="TenSach"/>
			</td>
			<td>
				<xsl:value-of select="TheLoai"/>
			</td>
			<td>
				<xsl:value-of select="SoTrang"/>
			</td>
			<td>
				<!--
				<xsl:variable name="gia">
					<xsl:choose>
						<xsl:when test="SoTrang&lt;100">
							<xsl:value-of select="SoTrang*4000"/>
						</xsl:when>
						<xsl:when test="SoTrang&lt;150">
							<xsl:value-of select="100*4000+(SoTrang-100)*3000"/>
						</xsl:when>
						<xsl:otherwise>
							<xsl:value-of select="100*4000+50*3000+(SoTrang-150)*2000"/>
						</xsl:otherwise>
					</xsl:choose>
				</xsl:variable>
				-->
				<xsl:choose>
					<xsl:when test="SoTrang &lt; 100">
						<xsl:value-of select="SoTrang*4000"/>
					</xsl:when>
					<xsl:when test="SoTrang&lt;150">
						<xsl:value-of select="100*4000+SoTrang*3000-100*3000"/>
					</xsl:when>
					<xsl:otherwise>
						<xsl:value-of select="100*4000+50*3000+SoTrang*2000-150*2000"/>
					</xsl:otherwise>
				</xsl:choose>
				
				
			</td>
		</tr>
	</xsl:template>
</xsl:stylesheet>
