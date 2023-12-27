<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
		<html>
			<head>
				<title>Quản Lý Sinh Viên</title>
			</head>
			<body>
				<h2>DANH SÁCH SINH VIÊN</h2>
				<xsl:for-each select="DSSV/sv">
					<xsl:variable name="biendiem" select="diem"/>
					<B>Mã SV: </B>
						<xsl:value-of select="@masv"/>
					<br/>
					<B>Họ Tên</B>
						<xsl:value-of select="hoten"/>
					<br/>
					<B>Điểm</B>
						<xsl:value-of select="diem"/>
					<br/>
					<B>Điểm bằng chữ: </B>
					<xsl:choose>
						<xsl:when test="$biendiem &lt; 5">Kém</xsl:when>
						<xsl:when test="$biendiem &gt; 8">Giỏi</xsl:when>
						<xsl:otherwise>Trung Bình</xsl:otherwise>
					</xsl:choose>
					<br/>
					<hr></hr>
				</xsl:for-each>
			</body>
		</html>
    </xsl:template>
</xsl:stylesheet>
