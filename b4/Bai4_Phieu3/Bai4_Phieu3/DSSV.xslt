<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
				xmlns:a="http://tempuri.org/DSSV.xsd"
>
	<xsl:output method="xml" indent="yes"/>

	<xsl:template match="/">
		<html>
			<head>
				<title>Kết quả học tập</title>
			</head>
			<body>
				<h3>BẢNG KẾT QUẢ HỌC TẬP</h3>
				<p>(Năm học 2019)</p>

				<table border ="0">
					<tr>
						Mã SV: <xsl:value-of select="a:kqht/a:namhoc/a:lop/a:sv/a:info/a:maSV"/>
					</tr>
					<tr>
						Họ tên: <xsl:value-of select="a:kqht/a:namhoc/a:lop/a:sv/a:info/a:hoTen"/>
					</tr>
					<tr>
						Ngày sinh: <xsl:value-of select="a:kqht/a:namhoc/a:lop/a:sv/a:info/a:ngaySinh"/>
					</tr>
					<tr>
						Lớp: <xsl:value-of select="a:kqht/a:namhoc/a:lop/@malop"/>
					</tr>
					
				</table>

				<table border ="2" cellpadding ="3">
					<tr>
						<td>STT</td>
						<td>Môn học</td>
						<td>Lần 1</td>
						<td>Lần 2</td>
						<td>Cả năm</td>
					</tr>
					<xsl:for-each select="a:kqht/a:namhoc/a:lop/a:sv/a:monhoc/a:mon">
						<tr>
							<td>
								<xsl:value-of select="@stt"/>
							</td>
							<td>
								<xsl:value-of select="@tenmon"/>
							</td>
							<td>
								<xsl:value-of select="a:Diem/a:lan1"/>
							</td>
							<td>
								<xsl:value-of select="a:Diem/a:lan2"/>
							</td>
							<td>
								<xsl:value-of select="a:Diem/a:caNam"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>

				<table border ="0">
					<tr>
						<td>
							Xếp loại học lực: <xsl:value-of select="a:kqht/a:namhoc/a:lop/a:sv/a:xeploai/a:hocLuc"/>
						</td>
						<td></td>
					</tr>
					<tr>
						<td>
							Xếp loại hạnh kiểm: <xsl:value-of select="a:kqht/a:namhoc/a:lop/a:sv/a:xeploai/a:hanhKiem"/>
						</td>
						<td></td>
					</tr>
					<tr>
						<td></td>
						<td>
							Giáo viên chủ nhiệm
						</td>
						
					</tr>
					<tr>
						<td></td>
						<td>
							<xsl:value-of select="a:kqht/a:namhoc/a:lop/@gvcn"/>
						</td>

					</tr>
					

				</table>

			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
