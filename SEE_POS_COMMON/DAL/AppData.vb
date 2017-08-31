Imports connLib.DBConnection
Imports secuLib.Security
Imports System.Data.SqlClient

Public Class AppData

    Public Sub New()

    End Sub

    Private Shared dtTable As DataTable
    Private query As String
    Private applicationSettings As ApplicationSetting
    Private parameterService As ParameterService

#Region "Reporting"

    Public Function ClipboardItemLastReceive(ByVal data As DataTable, opt As Integer) As DataTable
        dtTable = New DataTable

        Try
            If cn.State = ConnectionState.Closed Then cn.Open()

            With cm
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "BEGIN TRANSACTION DELETE FROM Tool.dbo.Sams COMMIT TRANSACTION"
                .ExecuteNonQuery()
            End With

            cn.Close()


            For a As Integer = 0 To data.Rows.Count - 1
                If Trim(data.Rows(a).Item(0)) <> "" Then

                    If opt = 0 Then
                        query = "BEGIN TRANSACTION " &
                                "INSERT INTO Tool.dbo.Sams " &
                                "SELECT TOP 1 stok_partnumber FROM " & applicationSettings.DB & ".dbo.hkstok " &
                                "WHERE stok_partnumber='" & data.Rows(a).Item(0) & "' " &
                                "AND Stok_txcode IN ('GR102','GR101','GR410') " &
                                "COMMIT TRANSACTION"

                    ElseIf opt = 1 Then
                        query = "BEGIN TRANSACTION " &
                                "INSERT INTO Tool.dbo.Sams " &
                                "SELECT type_partnumber FROM " & applicationSettings.DB & ".dbo.mtipe " &
                                "WHERE type_prodhier1='" & data.Rows(a).Item(0) & "' " &
                                "AND EXISTS (SELECT * FROM " & applicationSettings.DB & ".dbo.hkstok " &
                                "WHERE stok_partnumber=type_partnumber " &
                                "AND Stok_txcode IN ('GR102','GR101','GR410')) " &
                                "COMMIT TRANSACTION"

                    Else
                        query = "BEGIN TRANSACTION " &
                                "INSERT INTO Tool.dbo.Sams " &
                                "SELECT type_partnumber FROM " & applicationSettings.DB & ".dbo.mtipe " &
                                "WHERE type_prodhier5='" & data.Rows(a).Item(0) & "' " &
                                "AND EXISTS (SELECT * FROM " & applicationSettings.DB & ".dbo.hkstok " &
                                "WHERE stok_partnumber=type_partnumber " &
                                "AND Stok_txcode IN ('GR102','GR101','GR410')) " &
                                "COMMIT TRANSACTION"
                    End If


                    If cn.State = ConnectionState.Closed Then cn.Open()
                    With cm
                        .Connection = cn
                        .CommandTimeout = 0
                        .CommandText = query
                        .ExecuteNonQuery()
                    End With
                    cn.Close()
                End If

            Next

            If cn.State = ConnectionState.Closed Then cn.Open()
            With cm
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "BEGIN TRANSACTION SELECT Item,type_description Description," &
                                "(SELECT TOP 1 stok_date FROM " & applicationSettings.DB & ".dbo.hkstok " &
                                "WHERE stok_partnumber=item AND stok_txcode in ('GR102','GR101','GR410') " &
                                "ORDER BY stok_date DESC)BM_Date," &
                                "(SELECT TOP 1 stok_qty FROM " & applicationSettings.DB & ".dbo.hkstok " &
                                "WHERE stok_partnumber=item AND stok_txcode in ('GR102','GR101','GR410')  " &
                                "ORDER BY stok_date DESC)BM_Qty " &
                                "FROM tool.dbo.sams " &
                                "INNER JOIN " & applicationSettings.DB & ".dbo.mtipe ON type_partnumber=item " &
                                "COMMIT TRANSACTION"
            End With

            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable
            cn.Close()

        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try


    End Function

    Public Function ClipboardItemWarehouseStockLevel(ByVal data As DataTable, opt As Integer, wh As String) As DataTable
        dtTable = New DataTable

        Try
            If cn.State = ConnectionState.Closed Then cn.Open()

            With cm
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "BEGIN TRANSACTION DELETE FROM Tool.dbo.Sams COMMIT TRANSACTION"
                .ExecuteNonQuery()
            End With

            cn.Close()


            For a As Integer = 0 To data.Rows.Count - 1
                If Trim(data.Rows(a).Item(0)) <> "" Then

                    If opt = 0 Then 'item
                        query = "BEGIN TRANSACTION " &
                                "INSERT INTO Tool.dbo.Sams " &
                                "SELECT TOP 1 stok_partnumber FROM " & applicationSettings.DB & ".dbo.hkstok " &
                                "WHERE stok_partnumber='" & data.Rows(a).Item(0) & "' " &
                                "AND Stok_txcode IN ('GR102','GR101','GR410') " &
                                "COMMIT TRANSACTION"

                    ElseIf opt = 1 Then 'description
                        query = "BEGIN TRANSACTION " &
                                "INSERT INTO Tool.dbo.Sams " &
                                "SELECT type_partnumber FROM " & applicationSettings.DB & ".dbo.mtipe " &
                                "WHERE type_description LIKE '%" & data.Rows(a).Item(0) & "%' " &
                                "AND EXISTS (SELECT * FROM " & applicationSettings.DB & ".dbo.hkstok " &
                                "WHERE stok_partnumber=type_partnumber " &
                                "AND Stok_txcode IN ('GR102','GR101','GR410')) " &
                                "COMMIT TRANSACTION"
                    ElseIf opt = 2 Then 'isbn
                        query = "BEGIN TRANSACTION " &
                                "INSERT INTO Tool.dbo.Sams " &
                                "SELECT type_partnumber FROM " & applicationSettings.DB & ".dbo.mtipe " &
                                "WHERE type_spl_material1 LIKE '%" & data.Rows(a).Item(0) & "'% " &
                                "AND EXISTS (SELECT * FROM " & applicationSettings.DB & ".dbo.hkstok " &
                                "WHERE stok_partnumber=type_partnumber " &
                                "AND Stok_txcode IN ('GR102','GR101','GR410')) " &
                                "COMMIT TRANSACTION"
                    ElseIf opt = 3 Then 'prodhier1
                        query = "BEGIN TRANSACTION " &
                                "INSERT INTO Tool.dbo.Sams " &
                                "SELECT type_partnumber FROM " & applicationSettings.DB & ".dbo.mtipe " &
                                "WHERE type_prodhier1='" & data.Rows(a).Item(0) & "' " &
                                "AND EXISTS (SELECT * FROM " & applicationSettings.DB & ".dbo.hkstok " &
                                "WHERE stok_partnumber=type_partnumber " &
                                "AND Stok_txcode IN ('GR102','GR101','GR410')) " &
                                "COMMIT TRANSACTION"
                    ElseIf opt = 4 Then 'prodhier3
                        query = "BEGIN TRANSACTION " &
                                "INSERT INTO Tool.dbo.Sams " &
                                "SELECT type_partnumber FROM " & applicationSettings.DB & ".dbo.mtipe " &
                                "WHERE type_prodhier3='" & data.Rows(a).Item(0) & "' " &
                                "AND EXISTS (SELECT * FROM " & applicationSettings.DB & ".dbo.hkstok " &
                                "WHERE stok_partnumber=type_partnumber " &
                                "AND Stok_txcode IN ('GR102','GR101','GR410')) " &
                                "COMMIT TRANSACTION"
                    ElseIf opt = 5 Then 'prodhier4
                        query = "BEGIN TRANSACTION " &
                                "INSERT INTO Tool.dbo.Sams " &
                                "SELECT type_partnumber FROM " & applicationSettings.DB & ".dbo.mtipe " &
                                "WHERE type_prodhier4='" & data.Rows(a).Item(0) & "' " &
                                "AND EXISTS (SELECT * FROM " & applicationSettings.DB & ".dbo.hkstok " &
                                "WHERE stok_partnumber=type_partnumber " &
                                "AND Stok_txcode IN ('GR102','GR101','GR410')) " &
                                "COMMIT TRANSACTION"

                    Else 'prodhier5
                        query = "BEGIN TRANSACTION " &
                                "INSERT INTO Tool.dbo.Sams " &
                                "SELECT type_partnumber FROM " & applicationSettings.DB & ".dbo.mtipe " &
                                "WHERE type_prodhier5='" & data.Rows(a).Item(0) & "' " &
                                "AND EXISTS (SELECT * FROM " & applicationSettings.DB & ".dbo.hkstok " &
                                "WHERE stok_partnumber=type_partnumber " &
                                "AND Stok_txcode IN ('GR102','GR101','GR410')) " &
                                "COMMIT TRANSACTION"
                    End If


                    If cn.State = ConnectionState.Closed Then cn.Open()
                    With cm
                        .Connection = cn
                        .CommandTimeout = 0
                        .CommandText = query
                        .ExecuteNonQuery()
                    End With
                    cn.Close()
                End If

            Next

            query = "SELECT LTRIM(RTRIM(PART_PartNumber)) AS item,TYPE_Description name," &
                   "type_materialtype type,product_description product,type_prodhier1 prodhier1," &
                   "type_prodhier2 prodhier2,type_prodhier3 prodhier3,type_prodhier4 prodhier4," &
                   "type_prodhier5 prodhier5,type_materialinfo author, " &
                   "(SELECT TOP 1 mp_nextprice FROM " & applicationSettings.DB & ".dbo.mprice " &
                   "WHERE MP_PartNumber=PART_PartNumber " &
                   "AND MP_PriceGroup ='01' " &
                   "AND MP_EffectiveDate<= GETDATE() and MP_ExpDate >= GETDATE() " &
                   "ORDER BY MP_EffectiveDate desc)purchase,(Select TOP 1 mp_nextprice FROM " & applicationSettings.DB & ".dbo.mprice " &
                   "WHERE MP_PartNumber=PART_PartNumber " &
                   "AND MP_PriceGroup='02' " &
                   "AND MP_EffectiveDate<= GETDATE() and MP_ExpDate >= GETDATE() " &
                   "ORDER BY MP_EffectiveDate desc)het,PART_RFSStock stock " &
                   "FROM " & applicationSettings.DB & ".dbo.mpart WITH(NOLOCK) " &
                   "INNER JOIN " & applicationSettings.DB & ".dbo.mtipe WITH(NOLOCK) on TYPE_PartNumber=PART_PartNumber AND type_status<>1 " &
                   "INNER JOIN " & applicationSettings.DB & ".dbo.mctprod WITH(NOLOCK) on TYPE_Product=PRODUCT_code " &
                   "INNER JOIN " & applicationSettings.DB & ".dbo.mmca WITH(NOLOCK) on mat_tipe=type_materialtype " &
                   "WHERE PART_WH='" & wh & "' " &
                   "AND EXISTS(SELECT * FROM " & applicationSettings.DB & ".dbo.hkstok WITH(NOLOCK) WHERE stok_partnumber=part_partnumber " &
                   "AND stok_warehouse='" & wh & "') AND EXISTS (SELECT * FROM tool.dbo.sams WHERE item=type_partnumber)"


            If cn.State = ConnectionState.Closed Then cn.Open()
            With cm
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = query
            End With

            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable
            cn.Close()

        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try


    End Function

    Public Function ClipboardDataImportProductList(ByVal data As DataTable) As DataTable
        dtTable = New DataTable

        Try
            If cn.State = ConnectionState.Closed Then cn.Open()

            With cm
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "BEGIN TRANSACTION DELETE FROM Tool.dbo.Sams COMMIT TRANSACTION"
                .ExecuteNonQuery()
            End With

            cn.Close()


            For a As Integer = 0 To data.Rows.Count - 1
                If Trim(data.Rows(a).Item(0)) <> "" Then


                    query = "BEGIN TRANSACTION " &
                                "INSERT INTO Tool.dbo.Sams " &
                                "VALUES ('" & Trim(data.Rows(a).Item(0)) & "' ) " &
                                "COMMIT TRANSACTION"

                    If cn.State = ConnectionState.Closed Then cn.Open()
                    With cm
                        .Connection = cn
                        .CommandTimeout = 0
                        .CommandText = query
                        .ExecuteNonQuery()
                    End With
                    cn.Close()
                End If

            Next

            query = "select distinct LTRIM(RTRIM(TYPE_PartNumber)) AS sku,TYPE_Description2 AS product_name,TYPE_ProdHier1 AS brand_name," &
                        "case TYPE_MaterialType " &
                        "when '001' then type_product + '1' " &
                        "when '002' then type_product + '2' " &
                        "when '510' then type_product + '3' " &
                        "When '520' then type_product + '4' " &
                        "when '600' then type_product + '1' " &
                        "else type_product + '3' end AS type_name,ISNULL(type_prodhier2,'RE001') AS tag_name,'YES' AS track_inventory,( " &
                        "select TOp 1 CAST(MP_NextPrice AS DECIMAL(18,4)) FROM " & applicationSettings.DB & ".dbo.mprice " &
                        "where MP_PartNumber=TYPE_PartNumber " &
                        "and MP_EffectiveDate <= GETDATE() and MP_ExpDate >= GETDATE() " &
                        "And MP_PriceGroup='01' " &
                        "order by MP_EffectiveDate desc) AS store_supply_price,( " &
                        "select TOp 1 " &
                        "case when TYPE_TaxGroup='00' then CAST(MP_NextPrice AS DECIMAL(18,4)) else CAST(MP_NextPrice / 1.1 AS DECIMAL(18,4)) end FROM " & applicationSettings.DB & ".dbo.mprice " &
                        "where MP_PartNumber=TYPE_PartNumber " &
                        "and MP_EffectiveDate <= GETDATE() and MP_ExpDate >= GETDATE() " &
                        "And MP_PriceGroup='02' " &
                        "order by MP_EffectiveDate desc) AS store_retail_price,case when TYPE_TaxGroup='00' then '-' else 'PPN' end AS tax_name, " &
                        "(select TOp 1 CAST(MP_NextPrice AS DECIMAL(18,4)) FROM " & applicationSettings.DB & ".dbo.mprice " &
                        "where MP_PartNumber=TYPE_PartNumber " &
                        "and MP_EffectiveDate <= GETDATE() and MP_ExpDate >= GETDATE() " &
                        "And MP_PriceGroup='01' " &
                        "order by MP_EffectiveDate desc) AS company_supply_price,( " &
                        "select TOp 1 case when TYPE_TaxGroup='00' then CAST(MP_NextPrice AS DECIMAL(18,4)) else CAST(MP_NextPrice / 1.1 AS DECIMAL(18,4)) end FROM " & applicationSettings.DB & ".dbo.mprice " &
                        "where MP_PartNumber=TYPE_PartNumber " &
                        "And MP_EffectiveDate <= GETDATE() And MP_ExpDate >= GETDATE() " &
                        "and MP_PriceGroup='02' " &
                        "order by MP_EffectiveDate desc) AS wholesale_price,TYPE_SPL_Material1 AS product_code,'YES' AS can_be_ordered," &
                        "CASE WHEN TYPE_MaterialType IN ('520','510','610') THEN 'YES' " &
                        "ELSE 'NO' END AS is_consignment,'S' + type_prodhier5 AS supplier_code FROM " & applicationSettings.DB & ".dbo.MTIPE with (nolock) " &
                        "inner join " & applicationSettings.DB & ".dbo.MPDISC with (nolock) on product=TYPE_DiscGroup " &
                        "where DiscGroup='01' " &
                        "and Salesorg='101' " &
                        "And SalesOffice='0110' " &
                        "and exists (select * FROM tool.dbo.sams " &
                        "where item=type_partnumber)"

            If cn.State = ConnectionState.Closed Then cn.Open()
            With cm
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = query
            End With

            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable
            cn.Close()

        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try


    End Function

    Public Function ClipboardItemRealStock(ByVal data As DataTable, opt As Integer, search As String) As DataTable
        dtTable = New DataTable

        Try
            If cn.State = ConnectionState.Closed Then cn.Open()

            With cm
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "BEGIN TRANSACTION DELETE FROM Tool.dbo.tbl_real COMMIT TRANSACTION"
                .ExecuteNonQuery()
            End With

            cn.Close()

            If opt = 0 Then
                For a As Integer = 0 To data.Rows.Count - 1
                    If Trim(data.Rows(a).Item(0)) <> "" Then



                        query = "BEGIN TRANSACTION " &
                                "INSERT INTO Tool.dbo.tbl_real " &
                                "SELECT type_partnumber,type_description,part_rfsstock,0 FROM " & applicationSettings.DB & ".dbo.mtipe WITH(NOLOCK)" &
                                "INNER JOIN " & applicationSettings.DB & ".dbo.MPART WITH(NOLOCK) ON part_partnumber=type_partnumber " &
                                        "AND part_wh='" & parameterService.GetValueParamText("DEFAULT WH") & "' " &
                                "WHERE type_Partnumber='" & data.Rows(a).Item(0) & "' " &
                                "AND EXISTS (SELECT * FROM " & applicationSettings.DB & ".dbo.hkstok WITH(NOLOCK) " &
                                "WHERE stok_partnumber=type_partnumber " &
                                "AND Stok_txcode IN ('GR102','GR101','GR410','GR501','INIT')) " &
                                "COMMIT TRANSACTION"


                        If cn.State = ConnectionState.Closed Then cn.Open()
                        With cm
                            .Connection = cn
                            .CommandTimeout = 0
                            .CommandText = query
                            .ExecuteNonQuery()
                        End With
                        cn.Close()
                    End If

                Next
            ElseIf opt = 1 Then
                query = "BEGIN TRANSACTION " &
                        "INSERT INTO Tool.dbo.tbl_real " &
                        "SELECT type_partnumber,type_description,part_rfsstock,0 FROM " & applicationSettings.DB & ".dbo.mtipe WITH(NOLOCK) " &
                        "INNER JOIN " & applicationSettings.DB & ".dbo.MPART WITH(NOLOCK) ON part_partnumber=type_partnumber " &
                                "AND part_wh='" & parameterService.GetValueParamText("DEFAULT WH") & "' " &
                        "WHERE type_prodhier1='" & search & "' " &
                        "AND EXISTS (SELECT * FROM " & applicationSettings.DB & ".dbo.hkstok WITH(NOLOCK) " &
                        "WHERE stok_partnumber=type_partnumber " &
                        "AND Stok_txcode IN ('GR102','GR101','GR410','GR501','INIT')) " &
                        "COMMIT TRANSACTION"

                If cn.State = ConnectionState.Closed Then cn.Open()
                With cm
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = query
                    .ExecuteNonQuery()
                End With
                cn.Close()

            Else
                query = "BEGIN TRANSACTION " &
                        "INSERT INTO Tool.dbo.tbl_real " &
                        "SELECT type_partnumber,type_description,part_rfsstock,0 FROM " & applicationSettings.DB & ".dbo.mtipe WITH(NOLOCK) " &
                        "INNER JOIN " & applicationSettings.DB & ".dbo.MPART WITH(NOLOCK) ON part_partnumber=type_partnumber " &
                                "AND part_wh='" & parameterService.GetValueParamText("DEFAULT WH") & "' " &
                        "WHERE type_prodhier5='" & search & "' " &
                        "AND EXISTS (SELECT * FROM " & applicationSettings.DB & ".dbo.hkstok WITH(NOLOCK) " &
                        "WHERE stok_partnumber=type_partnumber " &
                        "AND Stok_txcode IN ('GR102','GR101','GR410','GR501','INIT')) " &
                        "COMMIT TRANSACTION"

                If cn.State = ConnectionState.Closed Then cn.Open()
                With cm
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = query
                    .ExecuteNonQuery()
                End With
                cn.Close()


            End If


            If cn.State = ConnectionState.Closed Then cn.Open()
            With cm
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "BEGIN TRANSACTION " &
                                "EXECUTE " & applicationSettings.DB & ".dbo.P_GET_STOCK_REAL " &
                                "COMMIT TRANSACTION"
            End With

            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            cn.Close()
            Return dtTable


        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try


    End Function

    Public Function ReportBestSeller(ByVal top As Integer, ByVal startDate As Date, ByVal endDate As Date,
                                  ByVal group As String, ByVal wh As String, ByVal branch As String, ByVal org As String) As DataTable

        Try

            If cn.State = ConnectionState.Closed Then cn.Open()
            dtTable = New DataTable

            If parameterService.GetValueParamNumber("SYSTEM SQL") = 0 Then
                query = "EXECUTE " & applicationSettings.DB & ".dbo.P_BestSeller '" & top & "','" & Format(startDate, applicationSettings.formatDate) & "','" & Format(endDate, applicationSettings.formatDate) & "','" & group & "','" & wh & "'," &
                                                  "'" & branch & "','" & org & "'"

            Else
                query = "SELECT TOP " & top & " LTRIM(RTRIM(tslsd.DS_PartNumber)) Item,mtipe.TYPE_Description Judul,mctprod.Product_Description Product," &
                        "mtipe.type_uom UOM,mprice.mp_nextprice HET,CAST(SUM(tslsd.DS_Qty) AS INT) Sales,CAST(mpart.PART_RFSStock AS INT) Stock " &
                        "FROM " & applicationSettings.DB & ".dbo.tslsd WITH(NOLOCK) " &
                        "INNER JOIN tslsh WITH(NOLOCK) on hs_invoicedate BETWEEN '" & Format(startDate, applicationSettings.formatDate) & "' " &
                        "AND '" & Format(endDate, applicationSettings.formatDate) & "' AND tslsh.hs_branch='" & branch & "' " &
                        "AND tslsh.hs_salesorg='" & org & "'  AND tslsh.hs_warehouse='" & wh & "' AND tslsh.HS_Invoice=tslsd.DS_Invoice " &
                        "INNER JOIN " & applicationSettings.DB & ".dbo.mtipe WITH(NOLOCK) on mtipe.type_product<>'120' and mtipe.type_status<>1 AND mtipe.TYPE_PartNumber=tslsd.DS_PartNumber " &
                        "INNER JOIN " & applicationSettings.DB & ".dbo.mctprod WITH(NOLOCK) on mctprod.PRODUCT_GROUP='" & group & "' AND mctprod.product_code=mtipe.TYPE_Product " &
                        "INNER JOIN " & applicationSettings.DB & ".dbo.mpart WITH(NOLOCK) on mpart.part_wh='" & wh & "' AND mpart.PART_PartNumber=tslsd.DS_PartNumber " &
                        "INNER JOIN " & applicationSettings.DB & ".dbo.mprice WITH(NOLOCK) ON mprice.mp_partnumber=tslsd.DS_PartNumber " &
                        "WHERE tslsd.DS_InvoiceDate BETWEEN '" & Format(startDate, applicationSettings.formatDate) & "' AND " &
                        "'" & Format(endDate, applicationSettings.formatDate) & "' " &
                        "AND mprice.mp_pricegroup='" & parameterService.GetValueParamText("HET PRICE") & "' " &
                        "AND mprice.mp_effectivedate <= '" & Format(parameterService.GetValueParamDate("SYSTEM DATE"), applicationSettings.formatDate) & "' " &
                        "AND mprice.mp_expdate >= '" & Format(parameterService.GetValueParamDate("SYSTEM DATE"), applicationSettings.formatDate) & "' " &
                        "GROUP BY tslsd.DS_PartNumber,mtipe.TYPE_Description,mctprod.Product_Description,mtipe.type_uom,mpart.PART_RFSStock,mprice.mp_nextprice " &
                        "ORDER BY SUM(tslsd.DS_Qty) DESC"
            End If




            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = query
            End With

            da = New SqlDataAdapter

            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            cn.Close()

        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try



        Return dtTable

    End Function

    Public Function GetDetailItemPOS(ByVal kode As String, ByVal discgroup As String, ByVal pricegroup As String) As DataTable
        dtTable = New DataTable
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            query = "SELECT TOP 1 type_partnumber,type_description,type_uom,Param_D1,Disc1 Disc1_Rate,Param_D2,Disc2 Disc2_Rate," &
                                "Param_D3,Disc3 Disc3_Rate,Param_D4,Disc4 Disc4_Rate,Param_D5,DiscPurch," &
                                "Role Disc_Role,mp_currentprice,mp_nextprice,mp_effectivedate," &
                                "mp_expdate,type_taxgroup,type_status,type_product,product_group,ISNULL(type_prodhier1,'')type_prodhier1,ISNULL(type_prodhier2,'')type_prodhier2," &
                                "ISNULL(type_prodhier3,'')type_prodhier3,ISNULL(type_prodhier4,'')type_prodhier4,ISNULL(type_prodhier5,'')type_prodhier5,type_discgroup from " & applicationSettings.DB & ".dbo.mtipe with (nolock) " &
                                "inner join (select Product_Disc,[description],role,Param_D1,Param_D2,Param_D3,Param_D4,param_d5," &
                                "Disc1,Disc2,Disc3,isnull(Disc4,0)Disc4,DiscPurch from mproddisc with (nolock) " &
                                "inner join mdisc on product_disc=param_group_prod " &
                                "inner join mpdisc on Product_Disc=product " &
                                "where Param_SalesOrg='" & parameterService.GetValueParamText("POS SLSORG") & "' and Param_Salesoffice='" & parameterService.GetValueParamText("POS SALESOFFICE") & "' " &
                                "and param_discgroup='" & discgroup & "' " &
                                "and SalesOffice='" & parameterService.GetValueParamText("POS SALESOFFICE") & "' and discgroup='" & discgroup & "' and Salesorg='" & parameterService.GetValueParamText("POS SLSORG") & "')as discgroup on type_discgroup=product_disc" &
                                " inner join " & applicationSettings.DB & ".dbo.mprice with (nolock) on type_partnumber=mp_partnumber" &
                                " inner join " & applicationSettings.DB & ".dbo.mctprod with (nolock) on product_code=type_product" &
                                " WHERE type_partnumber='" & kode & "' AND mp_pricegroup='" & pricegroup & "'" &
                                " AND mp_effectivedate <= '" & Format(parameterService.GetValueParamDate("SYSTEM DATE"), applicationSettings.formatDate) & "' " &
                                " AND mp_expdate >= '" & Format(parameterService.GetValueParamDate("SYSTEM DATE"), applicationSettings.formatDate) & "' " &
                                "ORDER BY mp_effectivedate DESC"

            cm = New SqlCommand

            With cm
                .Connection = cn
                .CommandTimeout = 1000
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With
            cn.Close()
            query = ""

        Catch ex As Exception
            cn.Close()

            Throw ex
        End Try

        Return dtTable
    End Function

    Public Function RptListingWarehouseReceive(ByVal kode As String, fromDt As Date, toDt As Date,
                                                      ByVal state As Integer) As DataTable
        dtTable = New DataTable
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()

            Select Case state
                Case 0
                    query = "SELECT hlbm_wrs docno,(SELECT DISTINCT dlbm_reffdoc FROM " & applicationSettings.DB & ".dbo.twrsd with(nolock)" &
                            " WHERE dlbm_wrs=hlbm_wrs)AS pono,hlbm_date docdate,hlbm_trnid trnid,hlbm_dn dn," &
                            "hlbm_dndate dndate,hlbm_note note," &
                            "CASE WHEN hlbm_flag_validate='Y' AND hlbm_flag_posting='Y' then 'Posted' " &
                            "WHEN hlbm_flag_validate='Y' AND hlbm_flag_posting='N' then 'Receive' " &
                            "ELSE 'Draft' END sts FROM " & applicationSettings.DB & ".dbo.twrsh with(nolock) where hlbm_date BETWEEN '" & Format(fromDt, applicationSettings.formatDate) & "' AND '" & Format(toDt, applicationSettings.formatDate) & "' " &
                            "AND hlbm_trnid IN ('GR102','GR101')"
                Case 1
                    query = "SELECT hlbm_wrs docno,(SELECT DISTINCT dlbm_reffdoc FROM " & applicationSettings.DB & ".dbo.twrsd with(nolock)" &
                            " WHERE dlbm_wrs=hlbm_wrs)AS pono,hlbm_date docdate,hlbm_trnid trnid,hlbm_dn dn," &
                            "hlbm_dndate dndate,hlbm_note note," &
                            "CASE WHEN hlbm_flag_validate='Y' AND hlbm_flag_posting='Y' then 'Posted' " &
                            "WHEN hlbm_flag_validate='Y' AND hlbm_flag_posting='N' then 'Receive' " &
                            "ELSE 'Draft' END sts FROM " & applicationSettings.DB & ".dbo.twrsh with(nolock) where hlbm_date BETWEEN '" & Format(fromDt, applicationSettings.formatDate) & "' AND '" & Format(toDt, applicationSettings.formatDate) & "' " &
                            "AND hlbm_trnid = 'GR410'"
                Case 2
                    query = "SELECT hlbm_wrs docno,(SELECT DISTINCT dlbm_reffdoc FROM " & applicationSettings.DB & ".dbo.twrsd with(nolock)" &
                            " WHERE dlbm_wrs=hlbm_wrs)AS pono,hlbm_date docdate,hlbm_trnid trnid,hlbm_dn dn," &
                            "hlbm_dndate dndate,hlbm_note note," &
                            "CASE WHEN hlbm_flag_validate='Y' AND hlbm_flag_posting='Y' then 'Posted' " &
                            "WHEN hlbm_flag_validate='Y' AND hlbm_flag_posting='N' then 'Receive' " &
                            "ELSE 'Draft' END sts FROM " & applicationSettings.DB & ".dbo.twrsh with(nolock) where hlbm_date BETWEEN '" & Format(fromDt, applicationSettings.formatDate) & "' AND '" & Format(toDt, applicationSettings.formatDate) & "' " &
                            "AND hlbm_trnid = 'TR100'"
                Case Else

                    query = "SELECT hlbm_wrs docno,(SELECT DISTINCT dlbm_reffdoc FROM " & applicationSettings.DB & ".dbo.twrsd with(nolock)" &
                            " WHERE dlbm_wrs=hlbm_wrs)AS pono,hlbm_date docdate,hlbm_trnid trnid,hlbm_dn dn," &
                            "hlbm_dndate dndate,hlbm_note note," &
                            "CASE WHEN hlbm_flag_validate='Y' AND hlbm_flag_posting='Y' then 'Posted' " &
                            "WHEN hlbm_flag_validate='Y' AND hlbm_flag_posting='N' then 'Receive' " &
                            "ELSE 'Draft' END sts FROM " & applicationSettings.DB & ".dbo.twrsh with(nolock) where hlbm_date BETWEEN '" & Format(fromDt, applicationSettings.formatDate) & "' AND '" & Format(toDt, applicationSettings.formatDate) & "' " &
                            "AND hlbm_trnid = 'GR401'"

            End Select

            If Trim(kode) <> "" Then
                query = query & " AND hlbm_supplier = '" & kode & "'"
            End If


            cm = New SqlCommand

            With cm
                .Connection = cn
                .CommandTimeout = 60
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With
            cn.Close()
            query = ""

        Catch ex As Exception
            cn.Close()

            Throw ex
        End Try

        Return dtTable
    End Function

    Public Function RptListingWarehouseMovement(ByVal kode As String, ByVal fromDt As Date, ByVal toDt As Date,
                                                       ByVal state As Integer) As DataTable
        dtTable = New DataTable
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()

            Select Case state
                Case 0
                    query = "SELECT hts_doi docno,hts_date docdate,hts_trnid trnid,hts_supplier supp," &
                            "hts_customer cust,hts_to_wh towh,hts_reffdoc dn,hts_note note," &
                            "CASE WHEN hts_pickflag='Y' AND hts_postingflag='Y' then 'Posted' " &
                            "WHEN hts_pickflag='Y' AND hts_postingflag='N' then 'Validate' " &
                            "ELSE 'Draft' END sts FROM " & applicationSettings.DB & ".dbo.ttsh WITH(NOLOCK) where hts_date BETWEEN '" & Format(fromDt, applicationSettings.formatDate) & "' AND '" & Format(toDt, applicationSettings.formatDate) & "' " &
                            "AND hts_trnid IN ('PN102','PN101')"

                    If Trim(kode) <> "All" Then query = query & " AND hts_supplier = '" & kode & "'"

                Case 1
                    query = "SELECT hts_doi docno,hts_date docdate,hts_trnid trnid,hts_supplier supp," &
                            "hts_customer cust,hts_to_wh towh,hts_reffdoc dn,hts_note note," &
                            "CASE WHEN hts_pickflag='Y' AND hts_postingflag='Y' then 'Posted' " &
                            "WHEN hts_pickflag='Y' AND hts_postingflag='N' then 'Validate' " &
                            "ELSE 'Draft' END sts FROM " & applicationSettings.DB & ".dbo.ttsh WITH(NOLOCK) where hts_date BETWEEN '" & Format(fromDt, applicationSettings.formatDate) & "' AND '" & Format(toDt, applicationSettings.formatDate) & "' " &
                            "AND hts_trnid = 'MM410'"

                    If Trim(kode) <> "All" Then query = query & " AND hts_customer = '" & kode & "'"

                Case Else
                    query = "SELECT hts_doi docno,hts_date docdate,hts_trnid trnid,hts_supplier supp," &
                            "hts_customer cust,hts_to_wh towh,hts_reffdoc dn,hts_note note," &
                            "CASE WHEN hts_pickflag='Y' AND hts_postingflag='Y' then 'Posted' " &
                            "WHEN hts_pickflag='Y' AND hts_postingflag='N' then 'Validate' " &
                            "ELSE 'Draft' END sts FROM " & applicationSettings.DB & ".dbo.ttsh WITH(NOLOCK) where hts_date BETWEEN '" & Format(fromDt, applicationSettings.formatDate) & "' AND '" & Format(toDt, applicationSettings.formatDate) & "' " &
                            "AND hts_trnid = 'MM106'"

                    If Trim(kode) <> "All" Then query = query & " AND hts_wh = '" & kode & "'"


            End Select




            cm = New SqlCommand

            With cm
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With
            cn.Close()
            query = ""

        Catch ex As Exception
            cn.Close()

            Throw ex
        End Try

        Return dtTable
    End Function

    Public Function GetPromo(ByVal salesoffice As String, ByVal kode As String, ByVal product As String, ByVal today As Date _
                                    , ByVal discgroup As String, ByVal prodhier1 As String _
                                    , ByVal prodhier2 As String, ByVal prodhier3 As String _
                                    , ByVal prodhier4 As String, ByVal prodhier5 As String) As DataTable
        Try

            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            If parameterService.GetValueParamNumber("SYSTEM SQL") = 1 Then
                query = "SELECT MDiscD.PromoID,MdiscH.Description,MdiscH.DiscType,MDiscD.PartNumber as item," &
                        "MDiscD.Description as description,MDiscD.Disc FROM MDiscD,MdiscH " &
                        "WHERE ( MDiscD.PromoID = MdiscH.PromoID ) and  " &
                        "( ( MdiscH.Salesoffice = '" & salesoffice & "' ) AND  " &
                        "(MDiscD.PartNumber = '" & kode & "' AND  " &
                        "MDiscD.Prodhier = '1') OR  " &
                        "(MDiscD.PartNumber = '" & Trim(discgroup) & "' AND  " &
                        "MDiscD.Prodhier = '2') OR  " &
                        "(MDiscD.PartNumber = '" & product & "' AND  " &
                        "MDiscD.Prodhier = '3') OR  " &
                        "(MDiscD.PartNumber = '" & Trim(prodhier1) & "' AND  " &
                        "MDiscD.Prodhier = '4') OR  " &
                        "(MDiscD.PartNumber = '" & Trim(prodhier2) & "' AND  " &
                        "MDiscD.Prodhier = '5') OR  " &
                        "(MDiscD.PartNumber = '" & Trim(prodhier3) & "' AND  " &
                        "MDiscD.Prodhier = '6')  OR  " &
                        "(MDiscD.PartNumber = '" & Trim(prodhier4) & "' AND  " &
                        "MDiscD.Prodhier = '7')  OR  " &
                        "(MDiscD.PartNumber = '" & Trim(prodhier5) & "' AND  " &
                        "MDiscD.Prodhier = '8') ) AND " &
                        "MdiscH.PeriodFrom <= '" & Format(today, applicationSettings.formatDate) & "' AND  " &
                        "MdiscH.Periodto >= '" & Format(today, applicationSettings.formatDate) & "' AND  " &
                        "mdisch.Validflag='Y' AND " &
                        "mdisch.Closeflag='N' AND " &
                        "mdisch.DiscType<>10"
            Else
                query = "EXECUTE " & applicationSettings.DB & ".dbo.P_PROMO_DISC '" & salesoffice & "','" & kode & "'"
            End If

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)

            End With

            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try

        Return dtTable
    End Function

    Public Function GetEventBestPrice(ByVal salesoffice As String, ByVal kode As String, ByVal product As String, ByVal today As Date _
                                    , ByVal discgroup As String, ByVal prodhier1 As String _
                                    , ByVal prodhier2 As String, ByVal prodhier3 As String _
                                    , ByVal prodhier4 As String, ByVal prodhier5 As String) As DataTable
        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            If parameterService.GetValueParamNumber("SYSTEM SQL") = 1 Then
                query = "SELECT MDiscD.PromoID,MdiscH.Description,MdiscH.DiscType,MDiscD.PartNumber as item," &
                        "MDiscD.Description as description,MDiscD.Disc FROM MDiscD,MdiscH " &
                        "WHERE ( MDiscD.PromoID = MdiscH.PromoID ) and  " &
                        "( ( MdiscH.Salesoffice = '" & salesoffice & "' ) AND  " &
                        "( MdiscH.PeriodFrom <= '" & Format(today, applicationSettings.formatDate) & "' ) AND  " &
                        "( MdiscH.Periodto >= '" & Format(today, applicationSettings.formatDate) & "' ) AND  " &
                        "(MDiscD.PartNumber = '" & kode & "' AND  " &
                        "MDiscD.Prodhier = '1') OR  " &
                        "(MDiscD.PartNumber = '" & Trim(discgroup) & "' AND  " &
                        "MDiscD.Prodhier = '2') OR  " &
                        "(MDiscD.PartNumber = '" & product & "' AND  " &
                        "MDiscD.Prodhier = '3') OR  " &
                        "(MDiscD.PartNumber = '" & Trim(prodhier1) & "' AND  " &
                        "MDiscD.Prodhier = '4') OR  " &
                        "(MDiscD.PartNumber = '" & Trim(prodhier2) & "' AND  " &
                        "MDiscD.Prodhier = '5') OR  " &
                        "(MDiscD.PartNumber = '" & Trim(prodhier3) & "' AND  " &
                        "MDiscD.Prodhier = '6')  OR  " &
                        "(MDiscD.PartNumber = '" & Trim(prodhier4) & "' AND  " &
                        "MDiscD.Prodhier = '7')  OR  " &
                        "(MDiscD.PartNumber = '" & Trim(prodhier5) & "' AND  " &
                        "MDiscD.Prodhier = '8') ) AND " &
                        "mdisch.Validflag='Y' AND " &
                        "mdisch.Closeflag='N' AND " &
                        "mdisch.DiscType=10"
            Else
                query = "EXECUTE " & applicationSettings.DB & ".dbo.P_PROMO_BESTPRICE '" & salesoffice & "','" & kode & "'"
            End If

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)

            End With

            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try

        Return dtTable
    End Function

    Public Function GetDiscMember(ByVal salesoffice As String, ByVal kode As String) As DataTable
        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = "EXECUTE " & applicationSettings.DB & ".dbo.P_PROMO_DISC_MEMBER '" & salesoffice & "','" & kode & "'"
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)

            End With

            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try

        Return dtTable
    End Function

    Public Function MemberExists(ByVal kode As String) As Boolean
        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = "SELECT cust_nama FROM " & applicationSettings.DB & ".dbo.Mcust " &
                                "WHERE cust_kode='" & kode & "' AND cust_type='02'"
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)

            End With

            If dtTable.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If

            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Function EmpIDExists(ByVal empid As String, userlogOn As String) As Boolean
        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = "SELECT cashierbal_userid FROM " & applicationSettings.DB & ".dbo.cashierbalance " &
                                "WHERE cashierbal_userid='" & applicationSettings.logOn & "' " &
                                "AND cashierbal_employeeid='" & Trim(empid) & "' " &
                                "AND CashierBal_CloseDate is null"
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)

            End With

            If dtTable.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If

            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Sub CreateBestPrice(ByVal doc As String)
        Try

            If cn.State = ConnectionState.Closed Then cn.Open()

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = "EXECUTE " & applicationSettings.DB & ".dbo.P_AUTO_BESTPRICE '" & doc & "'"
                .ExecuteNonQuery()
            End With

            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try

    End Sub

    Public Function ReportSalesSupplier(ByVal supp As String, ByVal dtFrom As Date, ByVal dtTo As Date, ByVal sts As String, ByVal wh As String) As DataTable
        Try
            dtTable = New DataTable

            If cn.State = ConnectionState.Closed Then cn.Open()

            If parameterService.GetValueParamNumber("SYSTEM SQL") = 1 Then
                query = "SELECT ROW_NUMBER() OVER(ORDER BY sum(tslsd.ds_qty) DESC) AS iden," &
                        "mtipe.type_spl_material1 vendor,LTRIM(RTRIM(tslsd.ds_partnumber)) item," &
                        "mtipe.type_description judul,mctprod.product_description product," &
                        "(SELECT TOP 1 mprice.mp_nextprice FROM " & applicationSettings.DB & ".dbo.mprice With(NOLOCK) " &
                        "WHERE  mprice.mp_partnumber=tslsd.ds_partnumber " &
                        "And mprice.mp_pricegroup='01' " &
                        "AND mprice.mp_effectivedate <= '" & Format(CDate(parameterService.GetValueParamText("SYSTEM DATE")), applicationSettings.formatDate) & "' " &
                        "AND mprice.mp_expdate >= '" & Format(CDate(parameterService.GetValueParamText("SYSTEM DATE")), applicationSettings.formatDate) & "' " &
                        "ORDER BY mprice.mp_effectivedate DESC) AS purchase," &
                        "sum(tslsd.ds_qty) qty,ROUND(sum(tslsd.ds_dpp+tslsd.ds_ppn),-2) amount," &
                        "CASE WHEN mmca.mat_status='C' then 'Consignment' else 'Credit' end sts," &
                        "mpart.part_rfsstock stock FROM " & applicationSettings.DB & ".dbo.tslsd with(nolock) " &
                        "INNER JOIN " & applicationSettings.DB & ".dbo.tslsh with(nolock) on tslsh.hs_invoicedate " &
                                "BETWEEN '" & Format(dtFrom, applicationSettings.formatDate) & "' AND '" & Format(dtTo, applicationSettings.formatDate) & "' AND tslsh.hs_warehouse='" & wh & "' " &
                                "AND tslsd.ds_invoice=tslsh.hs_invoice " &
                        "INNER JOIN " & applicationSettings.DB & ".dbo.mtipe with(nolock) on mtipe.type_prodhier5='" & supp & "' " &
                                "AND mtipe.type_partnumber=tslsd.ds_partnumber " &
                        "INNER JOIN " & applicationSettings.DB & ".dbo.mpart with(nolock) on mpart.part_wh='" & wh & "' " &
                                "AND mpart.part_partnumber=tslsd.ds_partnumber " &
                        "INNER JOIN " & applicationSettings.DB & ".dbo.mmca with(nolock) ON mmca.mat_tipe=mtipe.type_materialtype " &
                        "INNER JOIN " & applicationSettings.DB & ".dbo.mctprod with(nolock) on type_product=product_code " &
                        "WHERE tslsd.ds_invoicedate BETWEEN '" & Format(dtFrom, applicationSettings.formatDate) & "' " &
                             "AND '" & Format(dtTo, applicationSettings.formatDate) & "' "

                If sts <> "" Then
                    query = query + "AND mat_status='" & sts & "' "

                End If
                query = query + "GROUP BY tslsd.ds_partnumber,mtipe.type_description,mctprod.product_description," &
                                "mtipe.type_spl_material1,mmca.mat_status,mpart.part_rfsstock " &
                        "ORDER BY sum(tslsd.ds_qty) DESC"
            Else
                query = "EXECUTE " & applicationSettings.DB & ".dbo.P_SALES_SUPPLIER '" & supp & "','" & Format(dtFrom, applicationSettings.formatDate) & "'," &
                                            "'" & Format(dtTo, applicationSettings.formatDate) & "','" & sts & "','" & wh & "' "
            End If
            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            cn.Close()
        Catch ex As Exception

            cn.Close()
            Throw ex
        End Try

        Return dtTable
    End Function

    Public Function ReportStockAgingSupplier(ByVal wh As String, ByVal sts As String,
                                                    ByVal group As String, ByVal supp As String,
                                                    ByVal zero As String, n0 As Date, n1 As Date,
                                                    n2 As Date, n3 As Date, n4 As Date, n5 As Date) As DataTable
        Try
            dtTable = New DataTable

            If cn.State = ConnectionState.Closed Then cn.Open()

            If parameterService.GetValueParamNumber("SYSTEM SQL") = 1 Then
                query = "SELECT LTRIM(RTRIM(type_partnumber)) Item,LTRIM(RTRIM(type_description)) Judul," &
                        "(SELECT CAST(ISNULL(SUM(ds_qty),0) AS INTEGER) from TSLSD WITH(NOLOCK) " &
                        "WHERE MONTH(ds_invoicedate)=DATEPART(mm,'" & n5 & "') " &
                        "AND YEAR(ds_invoicedate)=DATEPART(yyyy,'" & n5 & "') " &
                        "AND DS_PartNumber=TYPE_PartNumber)N5," &
                        "(SELECT CAST(ISNULL(SUM(ds_qty),0) AS INTEGER) FROM " & applicationSettings.DB & ".dbo.TSLSD WITH(NOLOCK) " &
                        "WHERE month(ds_invoicedate)=DATEPART(mm,'" & n4 & "') " &
                        "AND YEAR(ds_invoicedate)=DATEPART(yyyy,'" & n4 & "') " &
                        "AND DS_PartNumber=TYPE_PartNumber)N4," &
                        "(SELECT CAST(ISNULL(SUM(ds_qty),0) AS INTEGER) FROM " & applicationSettings.DB & ".dbo.TSLSD WITH(NOLOCK) " &
                        "WHERE month(ds_invoicedate)=DATEPART(mm,'" & n3 & "') " &
                        "AND YEAR(ds_invoicedate)=DATEPART(yyyy,'" & n3 & "') " &
                        "AND DS_PartNumber=TYPE_PartNumber)N3," &
                        "(SELECT CAST(ISNULL(SUM(ds_qty),0) AS INTEGER) FROM " & applicationSettings.DB & ".dbo.TSLSD WITH(NOLOCK) " &
                        "WHERE month(ds_invoicedate)=DATEPART(mm,'" & n2 & "') " &
                        "AND YEAR(ds_invoicedate)=DATEPART(yyyy,'" & n2 & "') " &
                        "AND DS_PartNumber=TYPE_PartNumber)N2," &
                        "(SELECT CAST(ISNULL(SUM(ds_qty),0) AS INTEGER) FROM " & applicationSettings.DB & ".dbo.TSLSD WITH(NOLOCK) " &
                        "WHERE MONTH(ds_invoicedate)=DATEPART(mm,'" & n1 & "') " &
                        "AND YEAR(ds_invoicedate)=DATEPART(yyyy,'" & n1 & "') " &
                        "AND DS_PartNumber=TYPE_PartNumber)N1," &
                        "(SELECT CAST(ISNULL(SUM(ds_qty),0) AS INTEGER) FROM " & applicationSettings.DB & ".dbo.TSLSD WITH(NOLOCK) " &
                        "WHERE month(ds_invoicedate)=DATEPART(mm,'" & n0 & "') " &
                        "AND YEAR(ds_invoicedate)=DATEPART(yyyy,'" & n0 & "') " &
                        "AND DS_PartNumber=TYPE_PartNumber)N0," &
                        "CAST(part_rfsstock AS INTEGER) Stock,(select TOP 1 hlbm_wrs FROM " & applicationSettings.DB & ".dbo.TWRSD WITH(NOLOCK) " &
                        "INNER JOIN " & applicationSettings.DB & ".dbo.TWRSH WITH(NOLOCK) on HLBM_WRS=DLBM_WRS " &
                        "WHERE DLBM_PartNumber = TYPE_PartNumber " &
                        "AND HLBM_TrnID in ('GR102','GR101','GR410') " &
                        "ORDER BY HLBM_Date desc )Last_BM," &
                        "(SELECT TOP 1 hlbm_date FROM " & applicationSettings.DB & ".dbo.TWRSD WITH(NOLOCK) " &
                        "INNER JOIN " & applicationSettings.DB & ".dbo.TWRSH WITH(NOLOCK) on HLBM_WRS=DLBM_WRS " &
                        "WHERE DLBM_PartNumber = TYPE_PartNumber " &
                        "AND HLBM_TrnID in ('GR102','GR101','GR410') " &
                        "ORDER BY HLBM_Date desc )BM_Date," &
                        "(SELECT top 1 CAST(DLBM_StockQty AS INTEGER) FROM " & applicationSettings.DB & ".dbo.TWRSD WITH(NOLOCK) " &
                        "INNER JOIN " & applicationSettings.DB & ".dbo.TWRSH WITH(NOLOCK) on HLBM_WRS=DLBM_WRS " &
                        "WHERE DLBM_PartNumber = TYPE_PartNumber " &
                        "AND HLBM_TrnID in ('GR102','GR101','GR410') " &
                        "ORDER BY HLBM_Date desc )BM_Qty," &
                        "(SELECT TOP 1 hlbm_dn FROM " & applicationSettings.DB & ".dbo.TWRSD WITH(NOLOCK) " &
                        "INNER JOIN " & applicationSettings.DB & ".dbo.TWRSH WITH(NOLOCK) on HLBM_WRS=DLBM_WRS " &
                        "WHERE DLBM_PartNumber = TYPE_PartNumber " &
                        "AND HLBM_TrnID in ('GR102','GR101','GR410') " &
                        "ORDER BY HLBM_Date desc )DN," &
                        "ISNULL((SELECT TOP 1 TMatReqd.requestno FROM " & applicationSettings.DB & ".dbo.TMatReqd WITH(NOLOCK) " &
                        "INNER JOIN " & applicationSettings.DB & ".dbo.TMatReqH WITH(NOLOCK) ON tmatreqh.Requestno=TMatreqD.Requestno " &
                        "WHERE Partnumber = TYPE_PartNumber AND Warehouse= '" & wh & "' " &
                        "ORDER BY DocumentDate ),'')MR FROM " & applicationSettings.DB & ".dbo.MTIPE WITH(NOLOCK) " &
                        "INNER JOIN " & applicationSettings.DB & ".dbo.MCTPROD WITH(NOLOCK) on PRODUCT_Code=TYPE_Product " &
                        "INNER JOIN " & applicationSettings.DB & ".dbo.MPART WITH(NOLOCK) on part_partnumber=type_partnumber and PART_WH='" & wh & "' "

                If zero = "Y" Then
                    query = query + "AND part_rfsstock <> 0 "
                Else
                    query = query + "AND part_rfsstock = 0 "
                End If

                query = query + "AND EXISTS (SELECT * FROM " & applicationSettings.DB & ".dbo.HKSTOK WITH(NOLOCK) " &
                        "WHERE stok_warehouse='" & wh & "' AND STOK_PartNumber=PART_PartNumber) " &
                        "WHERE type_status<>1 and type_prodhier5='" & supp & "' " &
                        "AND EXISTS (select * FROM " & applicationSettings.DB & ".dbo.HKSTOK WITH(NOLOCK) WHERE stok_warehouse='" & wh & "' " &
                        "AND STOK_PartNumber=TYPE_PartNumber) AND product_group='" & group & "' " &
                        "AND EXISTS (select * FROM " & applicationSettings.DB & ".dbo.MMCA WITH(NOLOCK) " &
                        "WHERE mat_status='" & sts & "' AND Mat_Tipe=TYPE_MaterialType)"

            Else
                query = "EXECUTE " & applicationSettings.DB & ".dbo.P_STOCK_AGING '" & wh & "','" & sts & "'," &
                                            "'" & group & "','" & zero & "','" & Format(n0, applicationSettings.formatDate) & "'," &
                                            "'" & Format(n1, applicationSettings.formatDate) & "','" & Format(n2, applicationSettings.formatDate) & "'," &
                                            "'" & Format(n3, applicationSettings.formatDate) & "','" & Format(n4, applicationSettings.formatDate) & "', " &
                                            "'" & Format(n5, applicationSettings.formatDate) & "'"
            End If

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            cn.Close()
        Catch ex As Exception
            cm.CommandTimeout = 30
            cn.Close()
            Throw ex
        End Try

        Return dtTable
    End Function

    Public Function ReportSalesProducts(ByVal slsorg As String, ByVal dtFrom As Date, ByVal dtTo As Date,
                                               product As String, ByVal sts As String) As DataTable
        Try
            dtTable = New DataTable

            If cn.State = ConnectionState.Closed Then cn.Open()

            query = "SELECT LTRIM(RTRIM(tslsd.ds_partnumber)) AS Item,mtipe.TYPE_Description2 [Description]," &
                    "mctprod.PRODUCT_Description Product,CAST(SUM(tslsd.ds_qty) AS integer)Qty," &
                    "SUM(tslsd.ds_dpp+tslsd.ds_ppn) AS Amount " &
                    "FROM " & applicationSettings.DB & ".dbo.tslsd WITH(NOLOCK) " &
                    "INNER JOIN " & applicationSettings.DB & ".dbo.tslsh WITH(NOLOCK) on tslsh.hs_invoice=tslsd.ds_invoice " &
                             "AND hs_invoicedate BETWEEN '" & Format(dtFrom, applicationSettings.formatDate) & "' AND '" & Format(dtTo, applicationSettings.formatDate) & "' " &
                             "AND hs_salesorg LIKE '%" & slsorg & "%' " &
                    "INNER JOIN " & applicationSettings.DB & ".dbo.MTIPE WITH(NOLOCK) on mtipe.TYPE_PartNumber=tslsd.ds_partnumber " &
                             "AND MTIPE.type_product LIKE '%" & product & "%' " &
                    "INNER JOIN " & applicationSettings.DB & ".dbo.MCTPROD WITH(NOLOCK) on MCTPROD.PRODUCT_Code=MTIPE.TYPE_Product " &
                    "INNER JOIN " & applicationSettings.DB & ".dbo.MMCA WITH(NOLOCK) on MMCA.mat_tipe=MTIPE.type_materialtype " &
                            "AND MMCA.mat_status LIKE '%" & sts & "%' " &
                    "WHERE ds_invoicedate BETWEEN '" & Format(dtFrom, applicationSettings.formatDate) & "' AND '" & Format(dtTo, applicationSettings.formatDate) & "' " &
                    "GROUP BY tslsd.DS_PartNumber,mtipe.TYPE_Description2,MCTPROD.PRODUCT_Description"


            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandTimeout = 0
                .CommandType = CommandType.Text
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

        Catch ex As Exception

            cn.Close()
            Throw ex
        Finally
            cn.Close()
        End Try

        Return dtTable
    End Function

    Public Function ReportBaseOnSupplier(ByVal dtFrom As Date, ByVal dtTo As Date) As DataTable
        Try
            dtTable = New DataTable

            If cn.State = ConnectionState.Closed Then cn.Open()

            query = "with temp (code,name,consi_amt,consi_qty,credit_amt,credit_qty) AS ( " &
                    "select sup_supplier,sup_name,SUM(ds_ppn+ds_dpp),SUM(ds_qty),0,0 from tslsd WITH(NOLOCK) " &
                    "inner join MTIPE WITH(NOLOCK) on TYPE_PartNumber=DS_PartNumber " &
                            "and TYPE_MaterialType in ('510','520','610') " &
                            "and TYPE_Status<>1 " &
                    "inner join MSPL WITH(NOLOCK) on SUP_Supplier=TYPE_ProdHier5 and SUP_Sts=0 " &
                    "where ds_invoicedate between '" & Format(dtFrom, applicationSettings.formatDate) & "' " &
                    "and '" & Format(dtTo, applicationSettings.formatDate) & "' " &
                    "group by sup_supplier,sup_name " &
                    "union all " &
                    "select sup_supplier,sup_name,0,0,SUM(ds_ppn+ds_dpp),SUM(ds_qty) from tslsd WITH(NOLOCK) " &
                    "inner join MTIPE WITH(NOLOCK) on TYPE_PartNumber=DS_PartNumber " &
                            "and TYPE_MaterialType in ('001','002','600') " &
                            "and TYPE_Status<>1 " &
                    "inner join MSPL WITH(NOLOCK) on SUP_Supplier=TYPE_ProdHier5 and SUP_Sts=0 " &
                    "where ds_invoicedate between '" & Format(dtFrom, applicationSettings.formatDate) & "' " &
                    "and '" & Format(dtTo, applicationSettings.formatDate) & "' " &
                    "group by sup_supplier,sup_name " &
                    ") SELECT code,name,sum(consi_amt)consi_amt,sum(consi_qty)consi_qty,sum(credit_amt)credit_amt,sum(credit_qty)credit_qty from temp WITH(NOLOCK) " &
                    "group by code,name "

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandTimeout = 0
                .CommandType = CommandType.Text
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

        Catch ex As Exception
            cn.Close()
            Throw ex
        Finally
            cn.Close()
        End Try

        Return dtTable
    End Function

    Public Function ReportBaseOnSupplier2() As DataTable
        Try
            dtTable = New DataTable

            If cn.State = ConnectionState.Closed Then cn.Open()


            query = "with temp (code,name,consi,credit) AS( " &
                  "select type_prodhier5,sup_name,SUM(part_rfsstock * mp_nextprice),0 " &
                  "FROM " & applicationSettings.DB & ".dbo.MTIPE WITH (NOLOCK) " &
                  "inner join MPRICE on MP_PartNumber=TYPE_PartNumber and MP_PriceGroup='01' " &
                  "left join " & applicationSettings.DB & ".dbo.MSPL With (NOLOCK) On SUP_Supplier=TYPE_ProdHier5 " &
                  "inner join " & applicationSettings.DB & ".dbo.MPART WITH (NOLOCK) on PART_PartNumber=TYPE_PartNumber " &
                  "AND PART_WH='" & parameterService.GetValueParamText("DEFAULT WH") & "' " &
                  "where TYPE_MaterialType in ('510','520','610') " &
                  "AND MP_EffectiveDate <= GETDATE() and MP_ExpDate >= GETDATE() " &
                  "group by type_prodhier5,sup_name " &
                  "having sum(part_rfsstock)<>0 " &
                  "union all " &
                  "select type_prodhier5,sup_name,0,SUM(part_rfsstock*mp_nextprice) " &
                  "FROM " & applicationSettings.DB & ".dbo.MTIPE WITH (NOLOCK) " &
                  "inner join MPRICE on MP_PartNumber=TYPE_PartNumber and MP_PriceGroup='01' " &
                  "left join " & applicationSettings.DB & ".dbo.MSPL WITH (NOLOCK) on SUP_Supplier=TYPE_ProdHier5 " &
                  "inner join " & applicationSettings.DB & ".dbo.MPART WITH (NOLOCK) on PART_PartNumber=TYPE_PartNumber " &
                  "AND PART_WH='" & parameterService.GetValueParamText("DEFAULT WH") & "' " &
                  "where TYPE_MaterialType in ('001','002','600') " &
                  "AND MP_EffectiveDate <= GETDATE() and MP_ExpDate >= GETDATE() " &
                  "group by type_prodhier5,sup_name " &
                  "having sum(part_rfsstock)<>0 " &
                  ")SELECT code,name,sum(consi)consi,sum(credit)credit from temp " &
                   "group by code,name " &
                   "order by name "

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandTimeout = 0
                .CommandType = CommandType.Text
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

        Catch ex As Exception
            cn.Close()
            Throw ex
        Finally
            cn.Close()
        End Try

        Return dtTable
    End Function

    Public Function ReportInventoryDemand(ByVal period As Date, ByVal group As String, ByVal sts As String,
                                                 ByVal product As String, ByVal wh As String, ByVal opt As String,
                                                 ByVal optStock As String) As DataTable
        Try
            dtTable = New DataTable

            If cn.State = ConnectionState.Closed Then cn.Open()

            cm = New SqlCommand()


            With cm

                .CommandTimeout = 180
                .Connection = cn

                .CommandText = "EXECUTE " & applicationSettings.DB & ".dbo.P_INVENTORY_DEMAND '" & Format(period, applicationSettings.formatDate) & "','" & Trim(group) & "'," &
                                            "'" & sts & "','" & product & "','" & wh & "','" & opt & "','" & optStock & "'"

                query = "" & wh & "','" & opt & "','" & optStock + 1 & "'"


            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            cm.CommandTimeout = 30
            cn.Close()
        Catch ex As Exception
            cm.CommandTimeout = 30
            cn.Close()
            Throw ex
        End Try

        Return dtTable
    End Function

    Public Function GetWarehouseStockLevel(ByVal group As String, ByVal sts As String,
                                                  ByVal product As String, ByVal wh As String,
                                                  ByVal state As Integer, ByVal text As String,
                                                  ByVal OPTSTOCK As String) As DataTable
        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            If parameterService.GetValueParamNumber("SYSTEM SQL") = 0 Then
                query = "EXECUTE " & applicationSettings.DB & ".dbo.P_GETWAREHOUSESTOCKLEVEL '" & group & "'," &
                                    "'" & sts & "','" & product & "','" & wh & "','" & state & "'," &
                                    "'" & Trim(text) & "','" & OPTSTOCK & "'"
            Else
                query = "SELECT LTRIM(RTRIM(PART_PartNumber)) AS item,TYPE_Description name," &
                   "type_materialtype type,product_description product,type_prodhier1 prodhier1," &
                   "type_prodhier2 prodhier2,type_prodhier3 prodhier3,type_prodhier4 prodhier4," &
                   "type_prodhier5 prodhier5,type_materialinfo author," &
                   "(SELECT TOP 1 mp_nextprice FROM " & applicationSettings.DB & ".dbo.mprice with (nolock) " &
                   "WHERE MP_PartNumber=PART_PartNumber " &
                   "AND MP_PriceGroup ='01' " &
                   "AND MP_EffectiveDate<= GETDATE() and MP_ExpDate >= GETDATE() " &
                   "ORDER BY MP_EffectiveDate desc)purchase,(Select TOP 1 mp_nextprice FROM " & applicationSettings.DB & ".dbo.mprice with (nolock) " &
                   "WHERE MP_PartNumber=PART_PartNumber " &
                   "AND MP_PriceGroup='02' " &
                   "AND MP_EffectiveDate<= GETDATE() and MP_ExpDate >= GETDATE() " &
                   "ORDER BY MP_EffectiveDate desc)het,PART_RFSStock stock " &
                   "FROM " & applicationSettings.DB & ".dbo.mpart " &
                   "INNER JOIN " & applicationSettings.DB & ".dbo.mtipe with (nolock) on TYPE_PartNumber=PART_PartNumber AND type_status<>1 " &
                   "INNER JOIN " & applicationSettings.DB & ".dbo.mctprod with (nolock) on TYPE_Product=PRODUCT_code  AND product_group LIKE '%" & group & "%' " &
                   "INNER JOIN " & applicationSettings.DB & ".dbo.mmca with (nolock) on mat_tipe=type_materialtype AND mat_status LIKE '%" & sts & "%' " &
                   "WHERE PART_WH='" & wh & "' " &
                   "AND EXISTS(SELECT * FROM " & applicationSettings.DB & ".dbo.hkstok with (nolock) WHERE stok_partnumber=part_partnumber " &
                   "AND stok_warehouse='" & wh & "') "

                If state = 0 Then
                    If OPTSTOCK = "0" Then
                        query = query + "AND part_rfsstock>0 "
                    ElseIf OPTSTOCK = "1" Then
                        query = query + "AND part_rfsstock=0 "
                    Else
                        query = query + "AND part_rfsstock<0 "
                    End If

                End If

                If state = 0 Then
                    If product = "" Then
                        query = query + "AND TYPE_Product LIKE '%" & product & "%'"
                    Else
                        query = query + "AND TYPE_Product = '" & product & "'"
                    End If

                ElseIf state = 1 Then
                    query = query + "AND type_partnumber LIKE '%" & Trim(text) & "%'"
                ElseIf state = 2 Then
                    query = query + "AND type_description LIKE '%" & Trim(text) & "%'"
                ElseIf state = 3 Then
                    query = query + "AND type_spl_material2 LIKE '%" & Trim(text) & "%'"
                ElseIf state = 4 Then
                    query = query + "AND type_prodhier1 = '" & Trim(text) & "'"
                ElseIf state = 5 Then
                    query = query + "AND type_prodhier4 = '" & Trim(text) & "'"
                Else
                    query = query + "AND type_prodhier5 = '" & Trim(text) & "'"
                End If
            End If


            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Private Function LastDayOfMonth(ByVal aDate As DateTime) As Date

        Return New DateTime(aDate.Year,
           aDate.Month,
                            DateTime.DaysInMonth(aDate.Year, aDate.Month))
    End Function

    Public Function ReportInventorySupplier(ByVal supp As String, ByVal sts As String, ByVal wh As String) As DataTable
        Try

            Dim today As Date = CDate(parameterService.GetValueParamText("SYSTEM DATE"))
            dtTable = New DataTable

            If cn.State = ConnectionState.Closed Then cn.Open()

            If parameterService.GetValueParamText("SYSTEM SQL") = 1 Then
                query = "DECLARE @tmp table(vendor varchar(50),item varchar(13),judul varchar(255)," &
                        "product varchar(200),purchase money,discpurch money,stock int," &
                        "sts varchar(30)) "

                query = query + "INSERT INTO @tmp " &
                    "SELECT " &
                     "type_spl_material1 vendor,LTRIM(RTRIM(part_partnumber)) item," &
                     "type_description judul,product_description product," &
                     "(SELECT TOP 1 mp_nextprice FROM mprice WHERE mp_partnumber=part_partnumber " &
                     "AND mp_pricegroup='01' AND mp_effectivedate <= '" & Format(today, applicationSettings.formatDate) & "' " &
                     "AND mp_expdate >= '" & Format(today, applicationSettings.formatDate) & "') purchase,discpurch," &
                     "part_rfsstock stock,'' FROM mpart with(nolock) " &
                     "INNER JOIN " & applicationSettings.DB & ".dbo.mtipe with(nolock) on type_partnumber=part_partnumber " &
                     "INNER JOIN " & applicationSettings.DB & ".dbo.mmca with(nolock) on type_materialtype=mat_tipe " &
                     "INNER JOIN " & applicationSettings.DB & ".dbo.mctprod with(nolock) on type_product=product_code " &
                     "INNER JOIN " & applicationSettings.DB & ".dbo.mpdisc with(nolock) on type_discgroup=product WHERE type_prodhier5='" & supp & "' "

                If sts <> "" Then
                    query = query + " AND mat_status='" & sts & "' "
                End If

                query = query + "and part_wh='" & wh & "' and exists(select * FROM " & applicationSettings.DB & ".dbo.hkstok " &
                     "where stok_partnumber=part_partnumber " &
                     "and stok_txcode IN ('GR102','GR101','GR410','GR501')) and discgroup='01' " &
                     "and salesorg='" & parameterService.GetValueParamText("POS SLSORG") & "' " &
                     "And salesoffice='" & parameterService.GetValueParamText("POS SALESOFFICE") & "' And part_rfsstock <> 0 " &
                     "GROUP BY part_partnumber,type_description,product_description," &
                         "type_spl_material1,part_rfsstock,discpurch " &
                     "ORDER BY part_rfsstock DESC "

                query = query + "SELECT vendor,item,judul,product,purchase,discpurch" &
                        ",stock,ISNULL((purchase - (purchase * discpurch/100)) * stock,0) As amount,sts " &
                        "FROM @tmp"
            Else
                query = "EXECUTE " & applicationSettings.DB & ".dbo.P_INVENTORY_SUPPLIER '" & supp & "'," &
                                            "'" & sts & "','" & wh & "' "
            End If

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = query
            End With

            da = New SqlDataAdapter

            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            cn.Close()
        Catch ex As Exception

            cn.Close()
            Throw ex
        End Try

        Return dtTable
    End Function

    Public Function ListingSalesHeader(ByVal emp As String, ByVal dtFrom As Date,
                                             ByVal dtTo As Date, ByVal OPT As String) As DataTable
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            dtTable = New DataTable

            'If GetValueParamText("SYSTEM SQL") = 1 Then
            '    query = "DECLARE @temp table(invoice varchar(14),receipt varchar(14),pay1 char(1),pay2 char(1),pay3 char(1)) "
            '    query = query + " ;with temp (invoice,receipt,pay1,pay2,pay3) AS ( " &
            '            "select tpayrech.salesorderno,tpayrech.receiptno,'01',0,0 FROM " & applicationSettings.DB & ".dbo.tpayrecd WITH(NOLOCK)" &
            '            "INNER JOIN " & applicationSettings.DB & ".dbo.tpayrech WITH(NOLOCK) On " &
            '            "tpayrech.documentdate BETWEEN '" & Format(dtFrom, applicationSettings.formatDate) & "' " &
            '            "And '" & Format(dtTo, applicationSettings.formatDate) & "' " &
            '            "And EmployeeID Like '%" & IIf(emp = "Any", "", Trim(emp)) & "%' and tpayrech.receiptno=tpayrecd.receiptno " &
            '            "WHERE tpayrecd.paytype='01' " &
            '            "union all " &
            '            "select tpayrech.salesorderno,tpayrech.receiptno,0,'02',0 from tpayrecd WITH(NOLOCK) " &
            '            "INNER JOIN " & applicationSettings.DB & ".dbo.tpayrech WITH(NOLOCK) on " &
            '             "tpayrech.documentdate BETWEEN '" & Format(dtFrom, applicationSettings.formatDate) & "' " &
            '            "And '" & Format(dtTo, applicationSettings.formatDate) & "' " &
            '            "And EmployeeID Like '%" & IIf(emp = "Any", "", Trim(emp)) & "%' and tpayrech.receiptno=tpayrecd.receiptno " &
            '            "WHERE tpayrecd.paytype='02' " &
            '            "union all " &
            '            "select tpayrech.salesorderno,tpayrech.receiptno,0,0,'04' from tpayrecd WITH(NOLOCK) " &
            '            "INNER JOIN " & applicationSettings.DB & ".dbo.tpayrech WITH(NOLOCK) on " &
            '             "tpayrech.documentdate BETWEEN '" & Format(dtFrom, applicationSettings.formatDate) & "' " &
            '            "And '" & Format(dtTo, applicationSettings.formatDate) & "' " &
            '            "And EmployeeID Like '%" & IIf(emp = "Any", "", Trim(emp)) & "%' and tpayrech.receiptno=tpayrecd.receiptno " &
            '            "WHERE tpayrecd.paytype='04') " &
            '            "INSERT INTO @temp " &
            '            "SELECT invoice,receipt,SUM(pay1) pay1,SUM(pay2) pay2,SUM(pay3) pay3 from temp WITH(NOLOCK) " &
            '            "GROUP BY invoice,receipt " &
            '            "Select hs_invoice Invoice,hs_invoicedate [Date],hs_warehouse Warehouse," &
            '            "hs_customer Customer, hs_currency Currency, hs_grossamount Gross," &
            '            "hs_disc3_afteramt DPP, hs_ppn PPN, hs_totalAmount Total," &
            '            "cashamount+returnamount Cash, cardamount Card, Charges," &
            '            "hs_roundingamt Rounding, hs_employeeid Emp " &
            '            "FROM " & applicationSettings.DB & ".dbo.tslsh WITH(NOLOCK) " &
            '            "INNER Join @temp WITH(NOLOCK) ON invoice=hs_invoice " &
            '            "INNER JOIN " & applicationSettings.DB & ".dbo.tpayrech WITH(NOLOCK) ON " &
            '            "tpayrech.documentdate BETWEEN '" & Format(dtFrom, applicationSettings.formatDate) & "' " &
            '            "AND '" & Format(dtTo, applicationSettings.formatDate) & "' AND receiptno = receipt " &
            '            "WHERE hs_invoicedate BETWEEN '" & Format(dtFrom, applicationSettings.formatDate) & "' " &
            '            "AND '" & Format(dtTo, applicationSettings.formatDate) & "' "

            '    Select Case OPT
            '        Case "1"
            '            query = query + "AND pay2=0 AND pay1=1 AND pay3=0 "
            '        Case "2"
            '            query = query + "AND pay2=2 And pay1=0 And pay3=0 "
            '        Case "3"
            '            query = query + "AND pay2=0 And pay1=0 And pay3=4 "
            '        Case "4"
            '            query = query + "AND pay2=2 And pay1=1 And pay3=0 "
            '        Case "5"
            '            query = query + "AND pay2=0 And pay1=1 And pay3=4 "
            '        Case "6"
            '            query = query + "AND pay2=2 And pay1=0 And pay3=4 "
            '        Case "7"
            '            query = query + "AND pay2=2 And pay1=1 And pay3=4 "
            '        Case Else '0'
            '            'do nothing'
            '    End Select

            '    query = query + "AND hs_branch='" & Default_Branch & "' And EmployeeID Like '%" & IIf(emp = "Any", "", Trim(emp)) & "%'"

            query = "EXECUTE " & applicationSettings.DB & ".dbo.P_LISTING_SALES '" & parameterService.GetValueParamText("DEFAULT BRANCH") & "'," &
                                                 "'" & Format(dtFrom, applicationSettings.formatDate) & "','" & Format(dtTo, "yyyy-MM-dd") & "'," &
                                                 "'" & IIf(emp = "Any", "", Trim(emp)) & "','" & OPT & "'"


            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandTimeout = 180
                .CommandText = query


            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With



            Return dtTable
            cm.CommandTimeout = 30
            cn.Close()
        Catch ex As Exception
            cn.Close()
            cm.CommandTimeout = 30
            Throw ex
        End Try
    End Function

    Public Function ListingSalesAll(ByVal org As String, ByVal dtFrom As Date,
                                             ByVal dtTo As Date) As DataTable
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            dtTable = New DataTable

            query = "SELECT hs_invoice invoice,hs_invoicedate date,hs_customer customer," &
                    "hs_grossamount gross,hs_disc3_afteramt DPP,hs_ppn PPN,hs_totalAmount+hs_roundingamt Total," &
                    "hs_employeeid Emp,wh_description wh " &
                    "FROM " & applicationSettings.DB & ".dbo.tslsh WITH (NOLOCK) " &
                    "INNER JOIN " & applicationSettings.DB & ".dbo.mwh WITH (NOLOCK) on wh_kode=hs_warehouse " &
                    "WHERE hs_invoicedate between '" & Format(dtFrom, applicationSettings.formatDate) & "' " &
                    "AND '" & Format(dtTo, applicationSettings.formatDate) & "' " &
                    "AND hs_salesorg='" & org & "'"



            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = query


            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With



            Return dtTable
            cm.CommandTimeout = 30
            cn.Close()
        Catch ex As Exception
            cn.Close()
            cm.CommandTimeout = 30
            Throw ex
        End Try
    End Function

    Public Function DailySalesPayments(ByVal slsorg As String, ByVal emp As String, ByVal dtFrom As Date,
                                             ByVal dtTo As Date) As DataTable
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            dtTable = New DataTable


            query = "EXECUTE " & applicationSettings.DB & ".dbo.P_DAILY_SALES_PAYMENTS '" & Format(dtFrom, applicationSettings.formatDate) & "','" & Format(dtTo, "yyyy-MM-dd") & "'," &
                                "'" & slsorg & "','" & emp & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandTimeout = 180
                .CommandText = query


            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With



            Return dtTable
            cm.CommandTimeout = 30
            cn.Close()
        Catch ex As Exception
            cn.Close()
            cm.CommandTimeout = 30
            Throw ex
        End Try
    End Function

    Public Function ClosingCashier(ByVal dtFrom As Date,
                                             ByVal dtTo As Date) As DataTable
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            dtTable = New DataTable


            query = "SELECT cashierbal_id,cashierbal_userid,cashierbal_opendate" &
                            ",cashierbal_amount,cashierbal_totalcash" &
                            ",cashierbal_totalcard,cashierbal_totalcharge," &
                            "cashierbal_totalvoucher,cashierbal_closedate," &
                            "cashierbal_note,cashierbal_employeeId " &
                            "FROM " & applicationSettings.DB & ".dbo.cashierbalance with(nolock) " &
                    "WHERE YEAR(cashierbal_opendate)='" & Format(dtFrom, "yyyy") & "' " &
                    "AND MONTH(cashierbal_opendate)='" & Format(dtFrom, "MM") & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandTimeout = 180
                .CommandText = query


            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With



            Return dtTable
            cm.CommandTimeout = 30
            cn.Close()
        Catch ex As Exception
            cn.Close()
            cm.CommandTimeout = 30
            Throw ex
        End Try
    End Function

    Public Function ListingReceiveDetail(ByVal kode As String, fromDt As Date, toDt As Date,
                                                      ByVal state As Integer) As DataTable
        Try

            If cn.State = ConnectionState.Closed Then cn.Open()
            dtTable = New DataTable

            cm = New SqlCommand

            Select Case state
                Case 0
                    query = "SELECT LTRIM(RTRIM(hlbm_wrs)) docno,(SELECT DISTINCT LTRIM(RTRIM(dlbm_reffdoc)) FROM " & applicationSettings.DB & ".dbo.twrsd with(nolock)" &
                            " WHERE dlbm_wrs=hlbm_wrs)AS pono,hlbm_date docdate,LTRIM(RTRIM(dlbm_partnumber)) item," &
                            "LTRIM(RTRIM(type_description)) description,dlbm_uom uom,dlbm_stockqty qty " &
                            "FROM " & applicationSettings.DB & ".dbo.twrsh with(nolock) " &
                            "INNER JOIN " & applicationSettings.DB & ".dbo.twrsd with(nolock) ON dlbm_wrs=hlbm_wrs " &
                            "INNER JOIN " & applicationSettings.DB & ".dbo.mtipe with(nolock) ON dlbm_partnumber=type_partnumber " &
                            "WHERE hlbm_date BETWEEN '" & Format(fromDt, applicationSettings.formatDate) & "' AND '" & Format(toDt, applicationSettings.formatDate) & "' " &
                            "AND hlbm_trnid IN ('GR102','GR101')"
                Case 1
                    query = "SELECT LTRIM(RTRIM(hlbm_wrs)) docno,(SELECT DISTINCT LTRIM(RTRIM(dlbm_reffdoc)) FROM " & applicationSettings.DB & ".dbo.twrsd with(nolock)" &
                            " WHERE dlbm_wrs=hlbm_wrs)AS pono,hlbm_date docdate,LTRIM(RTRIM(dlbm_partnumber)) item," &
                            "LTRIM(RTRIM(type_description)) description,dlbm_uom uom,dlbm_stockqty qty " &
                            "FROM " & applicationSettings.DB & ".dbo.twrsh with(nolock) " &
                            "INNER JOIN " & applicationSettings.DB & ".dbo.twrsd with(nolock) ON dlbm_wrs=hlbm_wrs " &
                            "INNER JOIN " & applicationSettings.DB & ".dbo.mtipe with(nolock) ON dlbm_partnumber=type_partnumber " &
                            "WHERE hlbm_date BETWEEN '" & Format(fromDt, applicationSettings.formatDate) & "' AND '" & Format(toDt, applicationSettings.formatDate) & "' " &
                            "AND hlbm_trnid = 'GR410'"
                Case 2
                    query = "SELECT LTRIM(RTRIM(hlbm_wrs)) docno,(SELECT DISTINCT LTRIM(RTRIM(dlbm_reffdoc)) FROM " & applicationSettings.DB & ".dbo.twrsd with(nolock)" &
                            " WHERE dlbm_wrs=hlbm_wrs)AS pono,hlbm_date docdate,LTRIM(RTRIM(dlbm_partnumber)) item," &
                            "LTRIM(RTRIM(type_description)) description,dlbm_uom uom,dlbm_stockqty qty " &
                            "FROM " & applicationSettings.DB & ".dbo.twrsh with(nolock) " &
                            "INNER JOIN " & applicationSettings.DB & ".dbo.twrsd with(nolock) ON dlbm_wrs=hlbm_wrs " &
                            "INNER JOIN " & applicationSettings.DB & ".dbo.mtipe with(nolock) ON dlbm_partnumber=type_partnumber " &
                            "WHERE hlbm_date BETWEEN '" & Format(fromDt, applicationSettings.formatDate) & "' AND '" & Format(toDt, applicationSettings.formatDate) & "' " &
                            "AND hlbm_trnid = 'TR100'"
                Case Else

                    query = "SELECT LTRIM(RTRIM(hlbm_wrs)) docno,(SELECT DISTINCT LTRIM(RTRIM(dlbm_reffdoc)) FROM " & applicationSettings.DB & ".dbo.twrsd with(nolock)" &
                            " WHERE dlbm_wrs=hlbm_wrs)AS pono,hlbm_date docdate,LTRIM(RTRIM(dlbm_partnumber)) item," &
                            "LTRIM(RTRIM(type_description)) description,dlbm_uom uom,dlbm_stockqty qty " &
                            "FROM " & applicationSettings.DB & ".dbo.twrsh with(nolock) " &
                            "INNER JOIN " & applicationSettings.DB & ".dbo.twrsd with(nolock) ON dlbm_wrs=hlbm_wrs " &
                            "INNER JOIN " & applicationSettings.DB & ".dbo.mtipe with(nolock) ON dlbm_partnumber=type_partnumber " &
                            "WHERE hlbm_date BETWEEN '" & Format(fromDt, applicationSettings.formatDate) & "' AND '" & Format(toDt, applicationSettings.formatDate) & "' " &
                            "AND hlbm_trnid = 'GR401'"

            End Select

            If Trim(kode) <> "" Then
                query = query & " AND hlbm_supplier = '" & kode & "'"
            End If

            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable

            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Function ListingSalesDetail(ByVal doc As String) As DataTable
        Try

            If cn.State = ConnectionState.Closed Then cn.Open()
            dtTable = New DataTable

            cm = New SqlCommand

            With cm
                .Connection = cn
                .CommandText = "SELECT ROW_NUMBER() OVER(ORDER BY type_description) iden,RTRIM(LTRIM(ds_partnumber)) Item," &
                                "type_description description,ds_uom uom,ds_qty Qty,ds_dpp+ds_ppn amount " &
                                "FROM " & applicationSettings.DB & ".dbo.tslsd " &
                                "INNER JOIN " & applicationSettings.DB & ".dbo.mtipe on type_partnumber=ds_partnumber " &
                                "WHERE ds_invoice = '" & doc & "' ORDER BY type_description ASC"
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable

            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Function ListingMovementDetail(ByVal kode As String, ByVal fromDt As Date, ByVal toDt As Date,
                                                       ByVal state As Integer) As DataTable
        Try

            If cn.State = ConnectionState.Closed Then cn.Open()
            dtTable = New DataTable

            cm = New SqlCommand
            Select Case state
                Case 0
                    query = "SELECT hts_doi docno,hts_date docdate,type_spl_material1 vendor," &
                            "LTRIM(RTRIM(dts_partnumber)) item,type_description judul,type_uom uom,dts_qty qty " &
                            "FROM " & applicationSettings.DB & ".dbo.ttsh INNER JOIN " & applicationSettings.DB & ".dbo.ttsd WITH(NOLOCK) ON dts_doi=hts_doi " &
                            "INNER JOIN " & applicationSettings.DB & ".dbo.mtipe WITH(NOLOCK) on type_partnumber=dts_partnumber " &
                            "where hts_date BETWEEN '" & Format(fromDt, applicationSettings.formatDate) & "' AND '" & Format(toDt, applicationSettings.formatDate) & "' " &
                            "AND hts_trnid IN ('PN102','PN101') "

                    If kode <> "All" Then query = query & "AND hts_supplier='" & kode & "'"
                Case 1
                    query = "SELECT hts_doi docno,hts_date docdate,type_spl_material1 vendor," &
                            "LTRIM(RTRIM(dts_partnumber)) item,type_description judul,type_uom uom,dts_qty qty " &
                            "FROM " & applicationSettings.DB & ".dbo.ttsh INNER JOIN " & applicationSettings.DB & ".dbo.ttsd WITH(NOLOCK) ON dts_doi=hts_doi " &
                            "INNER JOIN " & applicationSettings.DB & ".dbo.mtipe WITH(NOLOCK) on type_partnumber=dts_partnumber " &
                            "where hts_date BETWEEN '" & Format(fromDt, applicationSettings.formatDate) & "' AND '" & Format(toDt, applicationSettings.formatDate) & "' " &
                            "AND hts_trnid = 'MM410' "

                    If kode <> "All" Then query = query & "AND hts_wh='" & kode & "'"
                Case Else
                    query = "SELECT hts_doi docno,hts_date docdate,type_spl_material1 vendor," &
                            "LTRIM(RTRIM(dts_partnumber)) item,type_description judul,type_uom uom,dts_qty qty " &
                            "FROM " & applicationSettings.DB & ".dbo.ttsh INNER JOIN " & applicationSettings.DB & ".dbo.ttsd WITH(NOLOCK) ON dts_doi=hts_doi " &
                            "INNER JOIN " & applicationSettings.DB & ".dbo.mtipe WITH(NOLOCK) on type_partnumber=dts_partnumber " &
                            "where hts_date BETWEEN '" & Format(fromDt, applicationSettings.formatDate) & "' AND '" & Format(toDt, applicationSettings.formatDate) & "' " &
                            "AND hts_trnid = 'MM106' "

                    If kode <> "All" Then query = query & "AND hts_wh='" & kode & "'"


            End Select



            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable

            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Function GetRoundingAmt(ByVal dtFrom As Date, ByVal dtTo As Date) As Decimal
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            dtTable = New DataTable

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = "SELECT SUM(Hs_RoundingAmt) FROM " & applicationSettings.DB & ".dbo.tslsh" &
                                " WHERE hs_Invoicedate BETWEEN '" & Format(dtFrom, "yyyy-MM-dd") & "'" &
                                " AND '" & Format(dtTo, "yyyy-MM-dd") & "'"
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With
        Catch ex As Exception
            Throw ex
        End Try

        If Not IsDBNull(dtTable.Rows(0).Item(0)) Then
            Return dtTable.Rows(0).Item(0)
        Else
            Return 0
        End If
    End Function

    Public Function GetRoundingAmtbyEmp(ByVal dtFrom As Date, ByVal dtTo As Date, empid As String) As Decimal
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            dtTable = New DataTable

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = "SELECT SUM(Hs_RoundingAmt) FROM " & applicationSettings.DB & ".dbo.tslsh" &
                                " WHERE hs_Invoicedate BETWEEN '" & Format(dtFrom, "yyyy-MM-dd") & "'" &
                                " AND '" & Format(dtTo, "yyyy-MM-dd") & "' AND hs_employeeid LIKE '%" & Trim(empid) & "%' "
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With
        Catch ex As Exception
            Throw ex
        End Try

        If Not IsDBNull(dtTable.Rows(0).Item(0)) Then
            Return dtTable.Rows(0).Item(0)
        Else
            Return 0
        End If
    End Function

    Public Function ReportSummarySalesItem(ByVal group As String, ByVal sts As String,
                                                  ByVal dtFrom As Date, ByVal dtTo As Date,
                                                  ByVal OPTPAYTYPE As String) As DataTable
        Try


            If cn.State = ConnectionState.Closed Then cn.Open()
            dtTable = New DataTable

            query = "EXECUTE " & applicationSettings.DB & ".dbo.P_SUMMARY_SALES_ITEM '" & Format(dtFrom, applicationSettings.formatDate) & "'," &
                                    "'" & Format(dtTo, applicationSettings.formatDate) & "','" & group & "','" & sts & "'," &
                                    "'" & OPTPAYTYPE & "'"
            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandTimeout = 1000
                .CommandText = query


            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With


            Return dtTable

            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Function GETStockCard(ByVal item As String, ByVal wh As String, ByVal fperiod As Date, ByVal tperiod As Date) As DataTable

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()


            query = "EXECUTE " & applicationSettings.DB & ".dbo.P_STOCKCARD '" & wh & "','" & item & "','" & Format(fperiod, applicationSettings.formatDate) & "','" & Format(tperiod, applicationSettings.formatDate) & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try

    End Function

    Public Function GETDetailTaxOrg(ByVal code As String) As DataTable

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()


            query = "SELECT tax_NPWP,tax_name,tax_address,tax_city FROM " & applicationSettings.DB & ".dbo.mtaxorg " &
                    "WHERE tax_organization='" & code & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter

            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try

    End Function

    Public Function GetDetailWH(ByVal code As String) As String

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()


            query = "SELECT wh_description FROM " & applicationSettings.DB & ".dbo.mwh " &
                    "WHERE wh_kode='" & code & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable.Rows(0).Item(0)
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try

    End Function

    Public Function GETDetailEmployee(ByVal code As String) As DataTable

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()


            query = "SELECT employeid,emp_name,emp_title FROM " & applicationSettings.DB & ".dbo.memp_employeid " &
                    "WHERE employeid='" & code & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter

            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try

    End Function

    Public Function GETDetailMember(ByVal code As String) As DataTable

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()


            query = "SELECT cust_nama,cust_type,cust_address_1,cust_phone," &
                    "cust_paytype,cust_discgroup,cust_pricegroup FROM " & applicationSettings.DB & ".dbo.mcust " &
                    "WHERE cust_kode='" & code & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter

            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try

    End Function

    Public Function ValidateVoucherAmt(ByVal code As String, ByRef id As String) As Decimal

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()


            query = "SELECT mvoucherd.voucherid,mvoucherd.amount FROM " & applicationSettings.DB & ".dbo.mvoucherd " &
                    "INNER JOIN " & applicationSettings.DB & ".dbo.mvoucherh ON mvoucherh.voucherid=mvoucherd.voucherid " &
                    "WHERE mvoucherd.vouchercode='" & code & "' AND mvoucherd.invoice is null " &
                    "AND validflag='Y' AND closeflag='N'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter

            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            If dtTable.Rows.Count > 0 Then
                id = dtTable.Rows(0).Item(0)
                Return dtTable.Rows(0).Item(1)
            Else
                Return 0
            End If
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try

    End Function

    Public Sub GETTaxInvoice(ByVal company As String, ByVal branch As String,
                                        ByVal taxorg As String, ByVal invoice As String,
                                        ByVal period As Date, ByVal customer As String, ByVal empid As String)

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()


            query = "EXECUTE " & applicationSettings.DB & ".dbo.P_PGentaxinvoice '" & company & "','" & branch & "'," &
                                "'" & Trim(taxorg) & "','" & Trim(invoice) & "'," &
                                "'" & Format(period, applicationSettings.formatDate) & "','" & Trim(customer) & "','" & Trim(empid) & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandTimeout = 1000
                .CommandText = query
                .ExecuteNonQuery()
            End With

            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try

    End Sub

    Public Sub PostingSales(ByVal company As String, ByVal branch As String,
                                       ByVal invoice As String,
                                       Optional ByVal userPost As String = "SYSTEM", Optional ByVal sts As String = "N")

        Try

            If cn.State = ConnectionState.Closed Then cn.Open()


            query = "EXECUTE " & applicationSettings.DB & ".dbo.p_posting_sales_pos '" & company & "','" & branch & "'," &
                                "'" & Trim(invoice) & "','" & userPost & "','" & sts & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandTimeout = 1000
                .CommandText = query
                .ExecuteNonQuery()
            End With

            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try

    End Sub

    Public Sub LockVoucherCode(ByVal id As String, ByVal code As String, ByVal invoice As String, ByVal empId As String)

        Try

            If cn.State = ConnectionState.Closed Then cn.Open()

            query = "UPDATE " & applicationSettings.DB & ".dbo.mvoucherd SET invoice='" & invoice & "'," &
                                    "used_at='" & Format(parameterService.GetValueParamDate("SYSTEM DATE"), applicationSettings.formatDate) & "'," &
                                    "employeeid='" & empId & "' " &
                                    "WHERE voucherid='" & id & "' AND vouchercode='" & code & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
                .ExecuteNonQuery()
            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub GETSystemDate()

        Try
            If cn.State = ConnectionState.Closed Then cn.Open()


            query = "EXECUTE " & applicationSettings.DB & ".dbo.P_SystemDate"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
                .CommandTimeout = 180
                .ExecuteNonQuery()
            End With
            cm.CommandTimeout = 30

            cn.Close()
        Catch ex As Exception
            cm.CommandTimeout = 30
            cn.Close()
            Throw ex
        End Try

    End Sub

    Public Function GETSalesConsignment(ByVal company As String, ByVal branch As String, ByVal supplier As String, ByVal period As Date) As DataTable

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()


            query = "EXECUTE " & applicationSettings.DB & ".dbo.P_SALES_CONSIGNMENT '" & company & "','" & branch & "','" & supplier & "','" & Format(period, applicationSettings.formatDate) & "','" & Format(period, applicationSettings.formatDate) & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter

            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try

    End Function

    Public Function GETDOCUMENTSTATUS(ByVal branch As String, ByVal kode As String) As DataTable

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()


            query = "EXECUTE " & applicationSettings.DB & ".dbo.P_GETDOCUMENTSTATUS '" & branch & "','" & kode & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter

            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Function GetDetailBranch() As DataTable
        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = "SELECT coy_branch,coy_description,coy_address01,coy_address02 " &
                               "FROM " & applicationSettings.DB & ".dbo.mbranch WHERE coy_branch='" & parameterService.GetValueParamText("DEFAULT BRANCH") & "'"

            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable

            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Sub RepairRFS(ByVal item As String, ByVal wh As String, ByVal saldo As Integer)
        Try

            If cn.State = ConnectionState.Closed Then cn.Open()


            query = "UPDATE " & applicationSettings.DB & ".dbo.mpart set part_consigmentstock='" & saldo & "',part_rfsstock='" & saldo & "',part_totalstock='" & saldo & "' " &
                    "WHERE part_partnumber='" & item & "' AND part_wh='" & wh & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
                .ExecuteNonQuery()
            End With

            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Sub

    Public Function GetMasterItem(ByVal opt As Integer, ByVal text As String) As DataTable

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            Select Case opt
                Case 0
                    query = "SELECT Item_Code,Item_Description,Mat_Status" &
                       ",Item_Vendor,Item_ISBN FROM " & applicationSettings.DB & ".dbo.items " &
                       " INNER JOIN " & applicationSettings.DB & ".dbo.materialtype ON Item_Type=Mat_type" &
                       " WHERE Item_Code LIKE '" & text & "' "
                Case 1
                    query = "SELECT Item_Code,Item_Description,Mat_Status" &
                         ",Item_Vendor,Item_ISBN FROM " & applicationSettings.DB & ".dbo.items " &
                         " INNER JOIN " & applicationSettings.DB & ".dbo.materialtype ON Item_Type=Mat_type" &
                         " WHERE Item_Description LIKE '" & text & "' "
                Case Else

            End Select

            cm = New SqlCommand

            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter

            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Function GetInterfacing() As DataTable

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()


            query = "SELECT urutan_proses,nama_tabel,last_doc " &
                    "FROM interfacing_dest.dbo.tbl_temp_doc " &
                    "ORDER BY urutan_proses ASC"

            cm = New SqlCommand

            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter

            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Function GetMovementDetail(ByVal no As String, sts As Integer) As DataTable

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            If sts = 0 Then 'return supplier
                query = "SELECT dts_doi document,hts_date date,hts_reffdoc reffdoc,hts_trnid transid," &
                  "LTRIM(RTRIM(sup_name)) supplier,sup_address_1 address,LTRIM(RTRIM(dts_partnumber)) partnumber," &
                  "LTRIM(RTRIM(type_description)) description,dts_uom uom,dts_qty qty,hts_note note,type_spl_material1 vendor " &
                  "FROM " & applicationSettings.DB & ".dbo.ttsd " &
                  "INNER JOIN " & applicationSettings.DB & ".dbo.ttsh ON hts_doi=dts_doi " &
                  "INNER JOIN " & applicationSettings.DB & ".dbo.mspl ON sup_supplier=hts_supplier " &
                  "INNER JOIN " & applicationSettings.DB & ".dbo.mtipe ON type_partnumber=dts_partnumber where dts_doi='" & no & "'"
            ElseIf sts = 1 Then 'interbranch
                query = "SELECT dts_doi document,hts_date date,hts_reffdoc reffdoc,hts_trnid transid," &
                 "LTRIM(RTRIM(cust_nama)) customer,cust_address_1 address,LTRIM(RTRIM(dts_partnumber)) partnumber," &
                 "LTRIM(RTRIM(type_description)) description,dts_uom uom,dts_qty qty,hts_note note,type_spl_material1 vendor " &
                 "FROM " & applicationSettings.DB & ".dbo.ttsd " &
                 "INNER JOIN " & applicationSettings.DB & ".dbo.ttsh ON hts_doi=dts_doi " &
                 "INNER JOIN " & applicationSettings.DB & ".dbo.mcust ON cust_kode=hts_customer " &
                 "INNER JOIN " & applicationSettings.DB & ".dbo.mtipe ON type_partnumber=dts_partnumber where dts_doi='" & no & "'"
            Else
                query = "SELECT dts_doi document,hts_date date,hts_reffdoc reffdoc,hts_trnid transid," &
                "LTRIM(RTRIM(wh_description)) warehouse,wh_address address,LTRIM(RTRIM(dts_partnumber)) partnumber," &
                "LTRIM(RTRIM(type_description)) description,dts_uom uom,dts_qty qty,hts_note note,type_spl_material1 vendor " &
                "FROM " & applicationSettings.DB & ".dbo.ttsd " &
                "INNER JOIN " & applicationSettings.DB & ".dbo.ttsh ON hts_doi=dts_doi " &
                "INNER JOIN " & applicationSettings.DB & ".dbo.mwh ON wh_kode=hts_to_wh " &
                "INNER JOIN " & applicationSettings.DB & ".dbo.mtipe ON type_partnumber=dts_partnumber where dts_doi='" & no & "'"
            End If


            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Function GetReceiveDetail(ByVal no As String, sts As Integer) As DataTable

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            If sts = 0 Then 'Goods Receive
                query = "SELECT dlbm_wrs document,hlbm_date date,dlbm_reffdoc reffdoc,hlbm_dn dn,hlbm_dndate dndate,hlbm_trnid transid," &
                  "LTRIM(RTRIM(sup_name)) supplier,sup_address_1 address,LTRIM(RTRIM(dlbm_partnumber)) partnumber," &
                  "LTRIM(RTRIM(type_description)) description,dlbm_uom uom,dlbm_stockqty qty,hlbm_note note " &
                  "FROM " & applicationSettings.DB & ".dbo.twrsd " &
                  "INNER JOIN " & applicationSettings.DB & ".dbo.twrsh ON hlbm_wrs=dlbm_wrs " &
                  "INNER JOIN " & applicationSettings.DB & ".dbo.mspl ON sup_supplier=hlbm_supplier " &
                  "INNER JOIN " & applicationSettings.DB & ".dbo.mtipe ON type_partnumber=dlbm_partnumber where dlbm_wrs='" & no & "'"
            ElseIf sts = 1 Then 'interbranch
                query = "SELECT dts_doi document,hts_date date,hts_reffdoc reffdoc,hts_trnid transid," &
                 "LTRIM(RTRIM(cust_nama)) customer,cust_address_1 address,LTRIM(RTRIM(dts_partnumber)) partnumber," &
                 "LTRIM(RTRIM(type_description)) description,dts_uom uom,dts_qty qty,hts_note note,type_spl_material1 vendor " &
                 "FROM " & applicationSettings.DB & ".dbo.ttsd " &
                 "INNER JOIN " & applicationSettings.DB & ".dbo.ttsh ON hts_doi=dts_doi " &
                 "INNER JOIN " & applicationSettings.DB & ".dbo.mcust ON cust_kode=hts_customer " &
                 "INNER JOIN " & applicationSettings.DB & ".dbo.mtipe ON type_partnumber=dts_partnumber where dts_doi='" & no & "'"
            Else
                query = "SELECT dts_doi document,hts_date date,hts_reffdoc reffdoc,hts_trnid transid," &
                "LTRIM(RTRIM(wh_description)) warehouse,wh_address address,LTRIM(RTRIM(dts_partnumber)) partnumber," &
                "LTRIM(RTRIM(type_description)) description,dts_uom uom,dts_qty qty,hts_note note,type_spl_material1 vendor " &
                "FROM " & applicationSettings.DB & ".dbo.ttsd " &
                "INNER JOIN " & applicationSettings.DB & ".dbo.ttsh ON hts_doi=dts_doi " &
                "INNER JOIN " & applicationSettings.DB & ".dbo.mwh ON wh_kode=hts_to_wh " &
                "INNER JOIN " & applicationSettings.DB & ".dbo.mtipe ON type_partnumber=dts_partnumber where dts_doi='" & no & "'"
            End If


            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

#End Region

#Region "Sales"
    'Point Of Sales

    Public Function ValidateOpenCashier() As DataTable

        Try
            dtTable = New DataTable
            query = "SELECT CashierBal_UserId,cashierbal_employeeid FROM " & applicationSettings.DB & ".dbo.cashierbalance" &
                    " WHERE CashierBal_UserId='" & applicationSettings.logOn & "'" &
                    " AND CashierBal_CLoseDate is null"

            If cn.State = ConnectionState.Closed Then cn.Open()

            cm = New SqlCommand

            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter

            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable

        Catch ex As Exception

            Throw ex

        End Try


    End Function

    Public Function ValidateOpenCashierEmpID(empid As String) As Boolean

        Try
            dtTable = New DataTable
            query = "SELECT CashierBal_UserId,cashierbal_employeeid FROM " & applicationSettings.DB & ".dbo.cashierbalance" &
                    " WHERE cashierbal_employeeid='" & empid & "'" &
                    " AND CashierBal_CLoseDate is null"

            If cn.State = ConnectionState.Closed Then cn.Open()

            cm = New SqlCommand

            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter

            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            If dtTable.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If


        Catch ex As Exception

            Throw ex

        End Try


    End Function

    Public Function GetOpenDetail(ByVal empId As String) As DataTable
        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = "SELECT CashierBal_OpenDate,CashierBal_Amount,Cashierbal_Shift,Emp_Name,cashierbal_employeeid" &
                                " FROM " & applicationSettings.DB & ".dbo.cashierbalance" &
                                " INNER JOIN " & applicationSettings.DB & ".dbo.memp_employeid ON cashierbal_employeeid=employeid" &
                                " WHERE CashierBal_userid='" & empId & "'" &
                                " AND CashierBal_CloseDate is null"
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With
        Catch ex As Exception
            Throw ex
        End Try

        Return dtTable
    End Function

    Public Function GetDatebyMonth(ByVal month As Integer, year As Integer) As DataTable
        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = "select period from mendofday " &
                                "where Month(period) = '" & month & "' " &
                                "and year(period)='" & year & "'"
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With
        Catch ex As Exception
            Throw ex
        End Try

        Return dtTable
    End Function

    Public Sub PromoDiscount(ByVal item As String)
        query = "select event_disctype,Devent_disc,event_active from " & applicationSettings.DB & ".dbo.eventdetail" &
                " inner join event on devent_id=event_id" &
                " where devent_item='" & item & "' " &
                " and event_startdate <= '" & Format(parameterService.GetValueParamDate("SYSTEM DATE"), "yyyy-MM-dd") & "' " &
                " and event_expdate >= '" & Format(parameterService.GetValueParamDate("SYSTEM DATE"), "yyyy-MM-dd") & "'"
    End Sub

    Public Sub VoidInvoice(ByVal doc As String, ByVal note As String)

        Try
            If cn.State = ConnectionState.Closed Then cn.Open()

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = "EXECUTE " & applicationSettings.DB & ".dbo.P_VOIDINVOICE '" & doc & "','" & note & "'"
                .ExecuteNonQuery()

            End With

            cn.Close()


        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Sub

    Public Function GETPOSJournalCode(ByVal doc As String) As String
        Dim kode As String
        Try

            If cn.State = ConnectionState.Closed Then cn.Open()
            dtTable = New DataTable

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = "SELECT JournalCode FROM " & applicationSettings.DB & ".dbo.mktrn_sls " &
                                "WHERE TxCode='" & doc & "'"

            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            If dtTable.Rows.Count > 0 Then
                kode = dtTable.Rows(0).Item(0)
            Else
                kode = "000"
            End If


        Catch ex As Exception
            Throw ex
        End Try

        Return kode

    End Function

#End Region

#Region "Inventory"

    Public Function GetTS(ByVal no As String, ByVal state As Integer) As DataTable

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            If state = 0 Then
                query = "SELECT dts_partnumber,dts_qty,hts_wh,hts_to_wh FROM " & applicationSettings.DB & ".dbo.ttsd " &
                                  "INNER JOIN " & applicationSettings.DB & ".dbo.ttsh ON hts_doi=dts_doi where dts_doi='" & no & "'"
            Else
                query = "EXECUTE " & applicationSettings.DB & ".dbo.P_GETDETAILREMAIN '" & no & "'"
            End If

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Function GetPromoHeader(ByVal state As Integer, ByVal salesOrg As String) As DataTable

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            If state = 0 Then
                query = "SELECT promoid,description,note,disctype,assignto,periodfrom,periodto," &
                        "prodhier,validflag,closeflag,autogenerate,minpayment,createuser,createdate FROM " & applicationSettings.DB & ".dbo.mdisch " &
                        "WHERE closeflag='N' AND salesorg='" & salesOrg & "'"
            Else
                query = "SELECT promoid,description,note,disctype,assignto,periodfrom,periodto," &
                       "prodhier,validflag,closeflag,autogenerate,minpayment,createuser,createdate FROM " & applicationSettings.DB & ".dbo.mdisch " &
                       "WHERE closeflag='Y' AND salesorg='" & salesOrg & "'"
            End If

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Function GetEventHeader(ByVal no As String) As DataTable

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            query = "SELECT promoid,description,note,disctype,assignto,periodfrom,periodto," &
                        "prodhier,validflag,closeflag,autogenerate,minpayment,createuser,createdate FROM " & applicationSettings.DB & ".dbo.mdisch " &
                        "WHERE promoid='" & no & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Function GetVoucherHeader(ByVal state As Integer, ByVal salesOrg As String) As DataTable

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            If state = 0 Then
                query = "SELECT voucherid,description,note,periodfrom,periodto," &
                       "vouchertype,validflag,closeflag,createuser,createdate FROM " & applicationSettings.DB & ".dbo.mvoucherh " &
                        "WHERE closeflag='N' AND salesorg='" & salesOrg & "'"
            Else
                query = "SELECT voucherid,description,note,periodfrom,periodto," &
                       "vouchertype,validflag,closeflag,createuser,createdate FROM " & applicationSettings.DB & ".dbo.mvoucherh " &
                       "WHERE closeflag='Y' AND salesorg='" & salesOrg & "'"
            End If

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Function GetPromoDetail(ByVal no As String) As DataTable

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            query = "SELECT item,partnumber,description,disc FROM " & applicationSettings.DB & ".dbo.mdiscd " &
                    "WHERE promoid='" & no & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Function GetVoucherDetail(ByVal no As String) As DataTable

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            query = "SELECT ROW_NUMBER() OVER(ORDER BY vouchercode ASC)iden,vouchercode,invoice,amount,used_at,employeeid FROM " & applicationSettings.DB & ".dbo.mvoucherd " &
                    "WHERE voucherid='" & no & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Function TSExists(ByVal no As String) As Boolean

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()


            query = "SELECT hlbm_dn FROM " & applicationSettings.DB & ".dbo.twrsh " &
                    "where hlbm_dn='" & no & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            If dtTable.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Sub ValidatePromo(ByVal no As String)

        Try

            If cn.State = ConnectionState.Closed Then cn.Open()


            query = "UPDATE " & applicationSettings.DB & ".dbo.mdisch SET validflag='Y' " &
                    "where promoid='" & no & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
                .ExecuteNonQuery()
            End With

            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Sub

    Public Sub ValidateVoucher(ByVal no As String)

        Try

            If cn.State = ConnectionState.Closed Then cn.Open()


            query = "UPDATE " & applicationSettings.DB & ".dbo.mvoucherh SET validflag='Y' " &
                    "where voucherid='" & no & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
                .ExecuteNonQuery()
            End With

            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Sub

    Public Sub ClosePromo(ByVal no As String)

        Try

            If cn.State = ConnectionState.Closed Then cn.Open()


            query = "UPDATE " & applicationSettings.DB & ".dbo.mdisch SET closeFlag='Y' " &
                    "where promoid='" & no & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
                .ExecuteNonQuery()
            End With

            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Sub

    Public Sub CloseVoucher(ByVal no As String)

        Try

            If cn.State = ConnectionState.Closed Then cn.Open()


            query = "UPDATE " & applicationSettings.DB & ".dbo.mvoucherh SET closeFlag='Y' " &
                    "where voucherid='" & no & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
                .ExecuteNonQuery()
            End With

            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Sub

    Public Function GETPO(ByVal no As String) As DataTable

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()


            query = "SELECT dpo_partnumber,dpo_qty,hpo_supplier,sup_name FROM " & applicationSettings.DB & ".dbo.tpod " &
                    "INNER JOIN " & applicationSettings.DB & ".dbo.tpoh ON dpo_po=hpo_ponumber " &
                    "INNER JOIN " & applicationSettings.DB & ".dbo.mspl ON hpo_supplier=sup_supplier " &
                    "WHERE dpo_po='" & no & "' AND dpo_supply=0"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter

            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Function ValidatePOStatus(ByVal no As String, ByVal transid As String) As Boolean

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()


            query = "SELECT hpo_ponumber FROM " & applicationSettings.DB & ".dbo.tpoh " &
                    "WHERE hpo_ponumber='" & no & "' AND hpo_tranid='" & transid & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            If dtTable.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Sub InsertDetailBM(ByVal transid As String, ByVal doc As String, ByVal reffType As String,
                                     ByVal reffdoc As String, ByVal dt As DataTable, ByVal custsupp As String, ByVal custsuppcode As String)
        Dim statusItem As String = ""

        Try

            If cn.State = ConnectionState.Closed Then cn.Open()

            cm = New SqlCommand
            With cm
                .Connection = cn

                For i As Integer = 0 To dt.Rows.Count - 1
                    .CommandText = "INSERT INTO " & applicationSettings.DB & ".dbo.twrsd " &
                                    "(dlbm_wrs,dlbm_refftype,dlbm_reffdoc,dlbm_partnumber,dlbm_product,dlbm_uom,dlbm_storeuom," &
                                    "dlbm_entryqty,dlbm_stockqty,dlbm_payqty,dlbm_binqty,dlbm_cost,dlbm_batcno,dlbm_description," &
                                    "dlbm_costcenter,dlbm_freightcost,dlbm_costunit,dlbm_exchrate) " &
                                    "VALUES ('" & doc & "','" & reffType & "','" & reffdoc & "','" & dt.Rows(i).Item(0) & "','" & dt.Rows(i).Item(2) & "'" &
                                    ",'" & dt.Rows(i).Item(3) & "','" & dt.Rows(i).Item(3) & "','" & dt.Rows(i).Item(4) & "'" &
                                    ",'" & dt.Rows(i).Item(4) & "',0,'" & dt.Rows(i).Item(4) & "',0,'','" & Replace(dt.Rows(i).Item(1), "'", "''") & "'" &
                                    ",'',0,0,1)"
                    .ExecuteNonQuery()

                    'statusItem = GetStatusItem(dt.Rows(i).Item(0))

                    'Call NewTransactionStock(parameterService.GetValueParamText("DEFAULT COMPANY"), parameterService.GetValueParamText("DEFAULT BRANCH"), Format(parameterService.GetValueParamDate("SYSTEM DATE"), "yyyy-MM-dd") _
                    '                         , transid, custsupp, custsuppcode, doc, parameterService.GetValueParamText("DEFAULT WH") _
                    '                         , dt.Rows(i).Item(0), dt.Rows(i).Item(4), "+", dt.Rows(i).Item(2), IIf(statusItem = "C", 5, 0) _
                    '                         , dt.Rows(i).Item(1), dt.Rows(i).Item(3))
                Next

            End With
        Catch ex As Exception
            With cm
                .Connection = cn
                .CommandText = "DELETE FROM " & applicationSettings.DB & ".dbo.twrsd WHERE dlbm_wrs='" & doc & "'"
                .ExecuteNonQuery()
            End With

            cm.CommandText = "DELETE FROM " & applicationSettings.DB & ".dbo.hkstok WHERE stok_document='" & doc & "'"
            cm.ExecuteNonQuery()

            cn.Close()
            Throw ex
        End Try
    End Sub

    Public Function GetStatusItem(ByVal item As String) As String
        Dim sts As String = ""
        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()
            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = "SELECT Mat_Status FROM " & applicationSettings.DB & ".dbo.mtipe " &
                                "INNER JOIN " & applicationSettings.DB & ".dbo.mmca on type_materialtype=mat_tipe " &
                                "WHERE type_partnumber='" & item & "'"
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            sts = dtTable.Rows(0).Item(0)

        Catch ex As Exception
            Throw ex
        End Try

        Return sts
    End Function

    Public Sub InsertHeaderBM(ByVal company As String, ByVal branch As String, ByVal doc As String, ByVal tgl As DateTime _
                                    , ByVal wh As String, ByVal fwh As String, ByVal transid As String, ByVal supplier As String, ByVal dn As String _
                                    , ByVal dnDate As DateTime, ByVal note As String, ByVal type As Integer)
        Try

            If cn.State = ConnectionState.Closed Then cn.Open()
            cm = New SqlCommand
            With cm
                .Connection = cn


                .CommandText = "INSERT INTO " & applicationSettings.DB & ".dbo.twrsh " &
                                "(hlbm_company,hlbm_branch,hlbm_wrs,hlbm_date,hlbm_dc,hlbm_wh,hlbm_trnid,hlbm_type," &
                                "hlbm_supplier,hlbm_customer,hlbm_fwh,hlbm_dn,hlbm_dndate,hlbm_note,hlbm_flag_aloc," &
                                "hlbm_flag_rls,hlbm_flag_posting,hlbm_flag_validate,hlbm_journal,hlbm_creator,hlbm_createdate," &
                                "hlbm_createtime,hlbm_last_modifier,hlbm_modifytime) " &
                                "VALUES ('" & company & "','" & branch & "','" & doc & "','" & Format(tgl, applicationSettings.formatDate) & "'" &
                                ",'" & branch & "','" & wh & "','" & transid & "','" & type & "','" & supplier & "'" &
                                ",'','" & fwh & "','" & dn & "','" & Format(dnDate, applicationSettings.formatDate) & "','" & note & "','Y','Y','N','N','101','" & applicationSettings.logOn & "'" &
                                ",'" & Format(tgl, applicationSettings.formatDate) & "','" & Format(Now, "HHmmss") & "'" &
                                ",'','')"
                .ExecuteNonQuery()


            End With

            cn.Close()

        Catch ex As Exception

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = "DELETE FROM " & applicationSettings.DB & ".dbo.twrsd WHERE dlbm_wrs='" & doc & "'"
                .ExecuteNonQuery()
            End With

            cm = New SqlCommand
            With cm
                .Connection = cn
                cm.CommandText = "DELETE FROM " & applicationSettings.DB & ".dbo.hkstok WHERE stok_document='" & doc & "'"
                cm.ExecuteNonQuery()

            End With

            cn.Close()

            Throw ex
        End Try
    End Sub

    Public Sub ValidateBM(ByVal doc As String, ByVal state As Integer)
        Try

            If cn.State = ConnectionState.Closed Then cn.Open()
            query = ""


            query = "EXECUTE " & applicationSettings.DB & ".dbo.P_VALIDATE_WRS '" & Trim(doc) & "','" & state & "'"
            cm = New SqlCommand
            With cm
                .Connection = cn

                .CommandText = query
                .ExecuteNonQuery()


            End With
        Catch ex As Exception

            cn.Close()
            Throw ex
        End Try
    End Sub

    Public Sub PostingBM(ByVal doc As String, ByVal wh As String, ByVal user As String)
        Try

            If cn.State = ConnectionState.Closed Then cn.Open()
            query = ""


            query = "EXECUTE " & applicationSettings.DB & ".dbo.P_Posting_WRS_POS '" & parameterService.GetValueParamText("DEFAULT BRANCH") & "'" &
                            ",'" & Trim(wh) & "','" & Trim(doc) & "','" & Trim(user) & "'"
            cm = New SqlCommand
            With cm
                .Connection = cn

                .CommandText = query
                .ExecuteNonQuery()


            End With



        Catch ex As Exception

            cn.Close()
            Throw ex

        End Try
    End Sub

    Public Sub InsertDetailTS(ByVal transid As String, ByVal doc As String, ByVal reffType As String,
                                     ByVal reffdoc As String, ByVal dt As DataTable, ByVal custsupp As String, ByVal custsuppcode As String)
        Dim statusItem As String = ""

        Try

            If cn.State = ConnectionState.Closed Then cn.Open()
            cm = New SqlCommand
            With cm
                .Connection = cn

                For i As Integer = 0 To dt.Rows.Count - 1
                    .CommandText = "INSERT INTO " & applicationSettings.DB & ".dbo.ttsd " &
                                    "(dts_doi,dts_partnumber,dts_product,dts_uom,dts_qty,dts_cost,dts_batchno," &
                                    "dts_uomunit,dts_note) " &
                                    "VALUES ('" & doc & "','" & dt.Rows(i).Item(0) & "','" & dt.Rows(i).Item(2) & "'" &
                                    ",'" & dt.Rows(i).Item(3) & "','" & dt.Rows(i).Item(4) & "',0" &
                                    ",'',1,'')"

                    .ExecuteNonQuery()

                    statusItem = 4

                    Call parameterService.NewTransactionStock(parameterService.GetValueParamText("DEFAULT COMPANY"), parameterService.GetValueParamText("DEFAULT BRANCH"), Format(parameterService.GetValueParamDate("SYSTEM DATE"), "yyyy-MM-dd") _
                                             , transid, custsupp, custsuppcode, doc, parameterService.GetValueParamText("DEFAULT WH") _
                                             , dt.Rows(i).Item(0), dt.Rows(i).Item(4), "-", dt.Rows(i).Item(2), statusItem _
                                             , dt.Rows(i).Item(1), dt.Rows(i).Item(3))
                Next

            End With
        Catch ex As Exception
            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = "DELETE FROM " & applicationSettings.DB & ".dbo.ttsd WHERE dts_doi='" & doc & "'"
                .ExecuteNonQuery()
            End With

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = "DELETE FROM " & applicationSettings.DB & ".dbo.hkstok WHERE stok_document='" & doc & "'"
                .ExecuteNonQuery()
            End With

            cn.Close()
            Throw ex
        End Try
    End Sub

    Public Sub InsertHeaderTS(ByVal company As String, ByVal branch As String, ByVal doc As String, ByVal tgl As DateTime _
                                    , ByVal wh As String, ByVal towh As String, ByVal transid As String, ByVal supplier As String, ByVal dn As String _
                                    , ByVal note As String)
        Try

            If cn.State = ConnectionState.Closed Then cn.Open()
            cm = New SqlCommand
            With cm
                .Connection = cn


                .CommandText = "INSERT INTO " & applicationSettings.DB & ".dbo.ttsh " &
                                "(hts_company,hts_branch,hts_salesorg,hts_salesoffice,hts_doi,hts_date,hts_dc," &
                                "hts_wh,hts_trnid,hts_supplier,hts_customer,hts_qq,hts_to_wh,hts_salesman," &
                                "hts_reffdoc,hts_alocflag,hts_pickflag,hts_dnflag,hts_postingflag,hts_tpflag," &
                                "hts_dn,hts_note,hts_deliveryroute,hts_costcenter,hts_journal,hts_counter," &
                                "hts_createuser,hts_createdate,hts_createtime) " &
                                "VALUES ('" & company & "','" & branch & "','','','" & doc & "','" & Format(tgl, applicationSettings.formatDate) & "'" &
                                ",'" & branch & "','" & wh & "','" & transid & "','','',''" &
                                ",'" & towh & "','','','Y','Y','Y','N','Y','','" & note & "','','','000',0,'" & applicationSettings.logOn & "'" &
                                ",'" & Format(tgl, applicationSettings.formatDate) & "','" & Format(Now, "HHmmss") & "')"
                .ExecuteNonQuery()


            End With
        Catch ex As Exception

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = "DELETE FROM " & applicationSettings.DB & ".dbo.ttsd WHERE dts_doi='" & doc & "'"
                .ExecuteNonQuery()
            End With

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = "DELETE FROM " & applicationSettings.DB & ".dbo.hkstok WHERE stok_document='" & doc & "'"
                .ExecuteNonQuery()
            End With

            cn.Close()
            Throw ex
        End Try
    End Sub

    Public Function GetCustAFFCO(ByVal kode As String) As String
        dtTable = New DataTable
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            query = "SELECT CUST_AFFCO FROM " & applicationSettings.DB & ".dbo.mcust WHERE Cust_Kode='" & kode & "' "
            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With
            cn.Close()
            query = ""

            If dtTable.Rows.Count > 0 Then
                Return dtTable.Rows(0).Item(0)
            Else
                Return "000"
            End If

        Catch ex As Exception

            Throw ex
        Finally
            cn.Close()
        End Try

    End Function

    Public Function GetJournalTran(ByVal transid As String, affco As String) As String
        dtTable = New DataTable
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            query = "SELECT JournalCode FROM " & applicationSettings.DB & ".dbo.MKTRNAFCO " &
                    "WHERE AFFCO='" & affco & "' " &
                    "AND txCode='" & transid & "'"
            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With
            cn.Close()
            query = ""

            If dtTable.Rows.Count > 0 Then
                Return dtTable.Rows(0).Item(0)
            Else
                Return "000"
            End If

        Catch ex As Exception

            Throw ex
        Finally
            cn.Close()
        End Try
    End Function

    Public Function GetDetailItem(ByVal kode As String) As DataTable

        dtTable = New DataTable
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            query = "SELECT type_partnumber,type_description,type_product,type_uom," &
                                "type_taxgroup,type_status,type_materialtype " &
                                "FROM " & applicationSettings.DB & ".dbo.mtipe WHERE type_partnumber='" & kode & "' "
            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With
            cn.Close()
            query = ""

        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try

        Return dtTable
    End Function

#End Region

#Region "Products"

#End Region

#Region "Customers"

#End Region

#Region "Accounting"

#End Region

#Region "Finance"

#End Region

#Region "Login User"

    Public Function ValidateUserExists(ByVal uid As String) As Boolean
        Dim result As Boolean = False
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            dtTable = New DataTable

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = "SELECT uid_user,uid_name,iud_usergroup FROM " & applicationSettings.DB & ".dbo.musers " &
                                " WHERE uid_user='" & uid & "' AND uid_blocksts=0"
            End With

            da = New SqlDataAdapter

            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            If dtTable.Rows.Count > 0 Then
                applicationSettings.logOn = dtTable.Rows(0).Item(0)
                applicationSettings.UserName = dtTable.Rows(0).Item(1)
                applicationSettings.UserGroup = dtTable.Rows(0).Item(2)
                result = True
            Else
                result = False
            End If

            cn.Close()

            Return result


        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Function PasswordCorrect(ByVal id As String, ByVal pass As String) As Boolean
        Dim result As Boolean = False
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            dtTable = New DataTable

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = "SELECT UID_Password FROM " & applicationSettings.DB & ".dbo.musers WHERE uid_user='" & id & "'"
            End With

            da = New SqlDataAdapter

            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            If decryptString(dtTable.Rows(0).Item(0)) = pass Then

                result = True
            Else
                result = False

            End If
            cn.Close()

            Return result
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Sub AddUser(ByVal id As String, ByVal name As String, ByVal password As String _
                                    , ByVal information As String, ByVal block As Integer, ByVal group As String)
        Dim result As Boolean = False
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            dtTable = New DataTable

            cm = New SqlCommand

            With cm
                .Connection = cn
                .CommandText = "INSERT INTO " & applicationSettings.DB & ".dbo.musers (uid_user,uid_name,uid_password,uid_information" &
                                ",uid_numberofattemp,uid_blocksts,uid_lastpwdlog,uid_forcechangepwd,iud_usergroup" &
                                ",uid_createuser,uid_createdate,uid_createtime)" &
                                " VALUES ('" & id & "','" & name & "','" & password & "','" & information & "'" &
                                ",0,'" & block & "',0,'N','" & Trim(group) & "','" & applicationSettings.logOn & "','" & Format(parameterService.GetValueParamDate("SYSTEM DATE"), applicationSettings.formatDate) & "'" &
                                ",'" & Format(Now, "HHmmss") & "')"
                .ExecuteNonQuery()
            End With


            cn.Close()


        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Sub

    Public Sub UpdateUser(ByVal id As String, ByVal name As String _
                                    , ByVal information As String, ByVal block As Integer, ByVal group As String)
        Dim result As Boolean = False
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            dtTable = New DataTable
            query = "UPDATE " & applicationSettings.DB & ".dbo.musers SET uid_name='" & name & "'," &
                                "uid_information='" & information & "',uid_blocksts='" & block & "'," &
                                "iud_usergroup='" & Trim(group) & "' WHERE uid_user='" & id & "'"

            With cm
                .Connection = cn
                .CommandText = query
                .ExecuteNonQuery()
            End With


            cn.Close()


        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Sub

    Public Sub SetUserOnline(ByVal userid As String, ByVal status As Integer)
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()

            With cm
                .Connection = cn
                .CommandText = "UPDATE " & applicationSettings.DB & ".dbo.musers SET User_Online='" & status & "'" &
                                " WHERE User_Id='" & userid & "'"
                .ExecuteNonQuery()
            End With

            cn.Close()

        Catch ex As Exception

            cn.Close()
            Throw ex
        End Try
    End Sub
#End Region

#Region "HRD/GA"

    Public Function GetEmployeeAll(ByVal company As String) As DataTable

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            query = "select EmployeID,Emp_Name,Emp_Title,Emp_Birthdate,Emp_BirthPlace,Emp_BirthCOuntry,Emp_Gender," &
                        "EMP_Bloodtype,EMP_BloodRhesus,Emp_CorrespondanceAddress1,Emp_CorrespondanceAddress2,Emp_CorrespondanceCity," &
                        "Emp_CorrespondanceCountry,EMP_CorrespondancePhone,EMP_CorrespondanceEmail,Emp_DateofHire,Emp_Nationality," &
                        "Emp_IDType,Emp_IDno,EMP_IDAddress,EMP_IDCity,EMP_ExpireDate,EMP_Issuedby,Emp_TaxNumber,Emp_Religion," &
                        "Emp_Status from " & applicationSettings.DB & ".dbo.memp_employeid WHERE emp_company='" & Trim(company) & "'"
            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter

            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Function GetEmployeeAssignment(ByVal company As String, ByVal branch As String) As DataTable

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            query = "select Temp_EmployeID,Emp_Name,Temp_NPK,Temp_CurrentAddress1 from memp_coy " &
                        "inner join MEMP_EmployeID on EmployeID=Temp_EmployeID WHERE temp_company='" & Trim(company) & "' " &
                        "AND temp_branch = '" & branch & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter

            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

#End Region

#Region "Menus"

    Public Function GetMenuAccess(ByVal userid As String) As DataTable

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            query = "SELECT userid,s.menudata,menuparent,menuform,menulevel,menuseq,menulabel," &
                    "haschild,menulock,lockmessage,isselect,isinsert,isedit,isdelete,isprint FROM " & applicationSettings.DB & ".dbo.MENUACCESS s " &
                    "INNER JOIN menus m ON s.menudata=m.menudata " &
                    "WHERE userid='" & userid & "' ORDER BY menuparent,menuseq"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Function GetAllMenuAccess() As DataTable

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            query = "SELECT menudata,menuparent,menuform,menulevel,menuseq,menulabel," &
                    "haschild,menulock,lockmessage FROM " & applicationSettings.DB & ".dbo.menus ORDER BY menuparent,menuseq"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Sub UpdateMenuAccess(ByVal mnu As String, ByVal userid As String, ByVal col As Integer, ByVal flag As Boolean)

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            Select Case col
                Case 2 'IsSelect
                    query = "UPDATE " & applicationSettings.DB & ".dbo.menuaccess SET isselect='" & flag & "' " &
                            "WHERE userid='" & userid & "' AND menudata='" & mnu & "'"
                Case 3 'IsInsert
                    query = "UPDATE " & applicationSettings.DB & ".dbo.menuaccess SET isinsert='" & flag & "' " &
                            "WHERE userid='" & userid & "' AND menudata='" & mnu & "'"
                Case 4 'IsEdit
                    query = "UPDATE " & applicationSettings.DB & ".dbo.menuaccess SET isedit='" & flag & "' " &
                            "WHERE userid='" & userid & "' AND menudata='" & mnu & "'"
                Case 5 'IsDelete
                    query = "UPDATE " & applicationSettings.DB & ".dbo.menuaccess SET isdelete='" & flag & "' " &
                            "WHERE userid='" & userid & "' AND menudata='" & mnu & "'"
                Case Else
                    query = "UPDATE " & applicationSettings.DB & ".dbo.menuaccess SET isprint='" & flag & "' " &
                            "WHERE userid='" & userid & "' AND menudata='" & mnu & "'"

            End Select

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
                .ExecuteNonQuery()
            End With


            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Sub

    Public Function CreateMenuAccess(ByVal menu As String) As DataTable

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            query = "EXECUTE " & applicationSettings.DB & ".dbo.P_CREATE_MENU_ACCESS '" & menu.ToUpper & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter

            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Function GetChildMenu(ByVal menu As String) As DataTable

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            query = "SELECT MenuData,menuForm,menulabel,menuname FROM " & applicationSettings.DB & ".dbo.menus " &
                    "WHERE menuparent='" & menu & "' AND haschild=1 ORDER BY menuseq ASC"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter

            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Function GetCharge(ByVal empId As String, ByVal dtFrom As Date, ByVal dtTo As Date) As Decimal

        Try
            Dim total As Decimal = 0
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            query = "SELECT SUM(charges) FROM " & applicationSettings.DB & ".dbo.tpayrech WHERE employeeid LIKE '%" & empId & "%' " &
                    "AND documentdate BETWEEN '" & Format(dtFrom, applicationSettings.formatDate) & "' AND '" & Format(dtTo, applicationSettings.formatDate) & "' "

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter

            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            If dtTable.Rows.Count > 0 Then
                If IsDBNull(dtTable.Rows(0).Item(0)) Then
                    total = 0
                Else
                    total = dtTable.Rows(0).Item(0)
                End If
            End If

            Return total
            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Sub InsertDetailBestPrice(ByVal item As String, ByVal disc As Decimal, ByVal empid As String)

        Try
            dtTable = New DataTable

            If cn.State = ConnectionState.Closed Then cn.Open()

            query = "EXECUTE " & applicationSettings.DB & ".dbo.P_DETAIL_BESTPRICE '" & item & "','" & disc & "','" & empid & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
                .ExecuteNonQuery()
            End With

            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Sub

    Public Sub CloseEvent()

        Try

            If cn.State = ConnectionState.Closed Then cn.Open()

            query = "UPDATE " & applicationSettings.DB & ".dbo.mdisch SET closeflag='Y' " &
                    "WHERE periodto < '" & Format(parameterService.GetValueParamDate("SYSTEM DATE"), applicationSettings.formatDate) & "' " &
                    "AND closeflag <> 'Y'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
                .ExecuteNonQuery()
            End With

            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Sub

    Public Sub CloseVoucher()

        Try

            If cn.State = ConnectionState.Closed Then cn.Open()

            query = "UPDATE " & applicationSettings.DB & ".dbo.mvoucherh SET closeflag='Y' " &
                    "WHERE periodto < '" & Format(parameterService.GetValueParamDate("SYSTEM DATE"), applicationSettings.formatDate) & "' " &
                    "AND closeflag <> 'Y'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
                .ExecuteNonQuery()
            End With


            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Sub

    Public Function BestPriceExists() As Boolean

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            query = "SELECT promoid FROM " & applicationSettings.DB & ".dbo.mdisch " &
                    "WHERE description='BEST PRICE' " &
                    "AND periodfrom='" & Format(parameterService.GetValueParamDate("SYSTEM DATE"), applicationSettings.formatDate) & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter

            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            If dtTable.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If

            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Function BestPriceOverload() As Integer

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            query = "SELECT count(mdiscd.partnumber) FROM " & applicationSettings.DB & ".dbo.mdiscd " &
                    "INNER JOIN " & applicationSettings.DB & ".dbo.mdisch on mdisch.promoid=mdiscd.promoid " &
                    "WHERE mdisch.description='BEST PRICE' " &
                    "AND mdisch.periodfrom='" & Format(parameterService.GetValueParamDate("SYSTEM DATE"), applicationSettings.formatDate) & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter

            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable.Rows(0).Item(0)

            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Function BestPriceDetail() As DataTable

        Try
            dtTable = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            query = "SELECT minMargin,MaxDisc,MaxItem FROM " & applicationSettings.DB & ".dbo.mdisch " &
                    "WHERE mdisch.description='BEST PRICE' AND mdisch.disctype=10  " &
                    "AND mdisch.periodfrom='" & Format(parameterService.GetValueParamDate("SYSTEM DATE"), applicationSettings.formatDate) & "' "

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter

            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            Return dtTable

            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try
    End Function

    Public Function GetParameter() As DataTable

        Try
            dtTable = New DataTable
            query = "SELECT Param_Code,Param_Description,Param_Flag,Param_Value,Param_Value_Type" &
                    " FROM " & applicationSettings.DB & ".dbo.mparam with (nolock)"

            If cn.State = ConnectionState.Closed Then cn.Open()

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            cn.Close()
        Catch ex As Exception
            cn.Close()
            Throw ex

        End Try

        Return dtTable
    End Function


#End Region

#Region "System"

    Public Sub UpdateCounter(ByVal lastdoc As Integer, ByVal year As String, ByVal kode As String)
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()

            cm = New SqlCommand

            With cm
                .Connection = cn
                .CommandTimeout = 1000
                .CommandText = "UPDATE " & applicationSettings.DB & ".dbo.mcountr SET CT_Last_Number='" & lastdoc & "'" &
                                " WHERE CT_Branch='" & applicationSettings.Default_Branch & "'" &
                                " AND CT_Year='" & year & "' AND CT_DocCode='" & kode & "'"
                .ExecuteNonQuery()
            End With
        Catch ex As Exception





            Throw ex
        End Try
    End Sub

    Public Sub CreateNewCounter(ByVal kode As String)
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandTimeout = 1000
                .CommandText = "INSERT INTO " & applicationSettings.DB & ".dbo.mcountr " &
                               "VALUES ('" & parameterService.GetValueParamText("DEFAULT COMPANY") & "','" & parameterService.GetValueParamText("DEFAULT BRANCH") & "'," &
                               "'" & kode & "','" & Format(parameterService.GetValueParamDate("SYSTEM DATE"), "yyyy") & "',0,'') "
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub UpdateHistoryPOS(ByVal invoice As String, ByVal kode As String)
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandTimeout = 1000
                .CommandText = "UPDATE " & applicationSettings.DB & ".dbo.hdoc SET Pos_Completed=9" &
                                " WHERE Pos_Document='" & invoice & "' AND Pos_TransDoc='" & kode & "'"
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub InsertHistoryPOS(ByVal doc As String, ByVal kode As String)
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandTimeout = 1000
                .CommandText = "INSERT INTO " & applicationSettings.DB & ".dbo.hdoc " &
                                " VALUES ('" & doc & "','" & kode & "','" & applicationSettings.logOn & "',0," &
                                "'" & Format(parameterService.GetValueParamDate("SYSTEM DATE"), "yyyy-MM-dd") & "')"

                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function CheckHistoryPOS(ByVal doc As String, ByVal kode As String) As Boolean
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            dtTable = New DataTable
            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandTimeout = 1000
                .CommandText = "SELECT pos_document FROM " & applicationSettings.DB & ".dbo.hdoc " &
                                " WHERE pos_document='" & doc & "' AND pos_transdoc='" & kode & "'"
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            If dtTable.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception

            Throw ex
        End Try
    End Function

    Public Function InvoiceExists(ByVal doc As String) As Boolean
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            dtTable = New DataTable
            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "SELECT hs_invoice FROM " & applicationSettings.DB & ".dbo.tslsh " &
                                " WHERE hs_invoice='" & doc & "'"
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            If dtTable.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception

            Throw ex
        End Try
    End Function

    Public Function InvoiceDetailExists(ByVal doc As String) As Boolean
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            dtTable = New DataTable
            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "SELECT ds_invoice FROM " & applicationSettings.DB & ".dbo.tslsd " &
                                " WHERE ds_invoice='" & doc & "'"
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            If dtTable.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception

            Throw ex
        End Try
    End Function

    Public Function PaymentExists(ByVal doc As String, receipt As String) As Boolean
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            dtTable = New DataTable
            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "SELECT salesorderno FROM " & applicationSettings.DB & ".dbo.tpayrech " &
                                "WHERE salesorderno='" & doc & "' " &
                                "AND receiptno='" & receipt & "'"
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            If dtTable.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception

            Throw ex
        End Try
    End Function

    Public Function PaymentDetailExists(ByVal doc As String) As Boolean
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            dtTable = New DataTable
            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "SELECT receiptno FROM " & applicationSettings.DB & ".dbo.tpayrecd " &
                                " WHERE receiptno='" & doc & "'"
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            If dtTable.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception

            Throw ex
        End Try
    End Function

    Public Function GetCounterDetail(ByVal kode As String) As DataTable
        dtTable = New DataTable

        Try
            If cn.State = ConnectionState.Closed Then cn.Open()

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandTimeout = 1000
                .CommandText = "SELECT CT_Year,CT_Last_Number FROM " & applicationSettings.DB & ".dbo.mcountr" &
                                " WHERE CT_Branch='" & parameterService.GetValueParamText("DEFAULT BRANCH") & "'" &
                                " AND CT_DocCode='" & kode & "'" &
                                " AND CT_Year='" & Format(parameterService.GetValueParamDate("SYSTEM DATE"), "yyyy") & "'"
            End With

            da = New SqlDataAdapter

            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With
        Catch ex As Exception
            Throw ex
        End Try

        Return dtTable
    End Function

    Public Function GetTempPOS(ByVal kode As String) As String
        dtTable = New DataTable
        Dim no As String

        Try
            If cn.State = ConnectionState.Closed Then cn.Open()

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandTimeout = 1000
                .CommandText = "SELECT Pos_Document FROM " & applicationSettings.DB & ".dbo.hdoc" &
                                " WHERE Pos_UserId='" & applicationSettings.logOn & "'" &
                                " AND Pos_TransDoc='" & kode & "' AND Pos_Completed=0"
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With


            If dtTable.Rows.Count = 0 Then
                no = ""

            Else
                no = dtTable.Rows(0).Item(0)
            End If

        Catch ex As Exception
            Throw ex
        End Try

        Return no
    End Function

    Public Sub UpdateSystemDate(ByVal d As Date, ByVal kode As String)

        Try
            If cn.State = ConnectionState.Closed Then cn.Open()

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandTimeout = 1000
                .CommandText = "UPDATE " & applicationSettings.DB & ".dbo.mparam SET Param_Value='" & Format(d, applicationSettings.formatDate) & "'" &
                                " WHERE Param_Description='" & kode & "'"
                .ExecuteNonQuery()
            End With

            If cn.State = ConnectionState.Closed Then cn.Open()

            With cm
                .Connection = cn
                .CommandTimeout = 1000
                .CommandText = "UPDATE " & applicationSettings.DB & ".dbo.msystem1 SET Param_today='" & Format(d, applicationSettings.formatDate) & "'" &
                                " WHERE Paramsys=1"
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function DNExists(ByVal kode As String) As Boolean
        dtTable = New DataTable
        Dim result As Boolean = False
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            query = "SELECT dlbm_partnumber FROM " & applicationSettings.DB & ".dbo.twrsd WHERE dlbm_ReffDoc='" & kode & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            If dtTable.Rows.Count > 0 Then
                result = True
            Else
                result = False
            End If
            cn.Close()
            query = ""

        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try

        Return result
    End Function

    Public Function ItemExists(ByVal kode As String) As Boolean
        dtTable = New DataTable
        Dim result As Boolean = False
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            query = "SELECT type_partnumber FROM " & applicationSettings.DB & ".dbo.mtipe WHERE type_partnumber='" & kode & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            If dtTable.Rows.Count > 0 Then
                result = True
            Else
                result = False
            End If
            cn.Close()
            query = ""

        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try

        Return result
    End Function

    Public Function ItemAssignmentExists(ByVal kode As String, wh As String) As Boolean
        dtTable = New DataTable
        Dim result As Boolean = False
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            query = "SELECT part_partnumber FROM " & applicationSettings.DB & ".dbo.mpart " &
                    "WHERE part_partnumber='" & kode & "' " &
                    "AND part_wh='" & wh & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            If dtTable.Rows.Count > 0 Then
                result = True
            Else
                result = False
            End If
            cn.Close()
            query = ""

        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try

        Return result
    End Function

    Public Function ItemBelongsSupplier(ByVal kode As String, supp As String) As Boolean
        dtTable = New DataTable
        Dim result As Boolean = False
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            query = "SELECT type_partnumber FROM " & applicationSettings.DB & ".dbo.mtipe " &
                    "WHERE type_partnumber='" & kode & "' " &
                    "AND type_prodhier5='" & supp & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            If dtTable.Rows.Count > 0 Then
                result = True
            Else
                result = False
            End If
            cn.Close()
            query = ""

        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try

        Return result
    End Function

    Public Function PriceExists(ByVal kode As String, ByVal pricegroup As String) As Boolean
        dtTable = New DataTable
        Dim result As Boolean = False
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            query = "SELECT mp_partnumber FROM " & applicationSettings.DB & ".dbo.mprice with (nolock) " &
                    "WHERE mp_pricegroup='" & pricegroup & "' AND mp_effectivedate <= '" & Format(Now, applicationSettings.formatDate) & "' " &
                    " AND mp_expdate >= '" & Format(Now, applicationSettings.formatDate) & "' AND mp_partnumber='" & kode & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            If dtTable.Rows.Count > 0 Then
                result = True
            Else
                result = False
            End If
            cn.Close()
            query = ""

        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try

        Return result
    End Function

    Public Function DiscRoleExists(ByVal kode As String, ByVal discgroup As String) As Boolean
        dtTable = New DataTable
        Dim result As Boolean = False
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            query = "SELECT product_disc FROM " & applicationSettings.DB & ".dbo.mtipe " &
                    "INNER JOIN " & applicationSettings.DB & ".dbo.mproddisc ON product_disc=type_discgroup " &
                    "WHERE type_partnumber='" & kode & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            If dtTable.Rows.Count > 0 Then
                result = True
            Else
                result = False
            End If
            cn.Close()
            query = ""

        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try

        Return result
    End Function

    Public Function DiscPolicyExists(ByVal kode As String, ByVal discgroup As String) As Boolean
        dtTable = New DataTable
        Dim result As Boolean = False
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            query = "SELECT param_group_prod FROM " & applicationSettings.DB & ".dbo.mtipe " &
                    "INNER JOIN " & applicationSettings.DB & ".dbo.mdisc ON param_group_prod=type_discgroup " &
                    "WHERE type_partnumber='" & kode & "' AND param_salesorg='" & parameterService.GetValueParamText("POS SLSORG") & "' " &
                    "AND param_salesoffice='" & parameterService.GetValueParamText("POS SALESOFFICE") & "' " &
                    "AND param_discgroup='" & discgroup & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            If dtTable.Rows.Count > 0 Then
                result = True
            Else
                result = False
            End If
            cn.Close()
            query = ""

        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try

        Return result
    End Function

    Public Function DiscRateExists(ByVal kode As String, ByVal discgroup As String) As Boolean
        dtTable = New DataTable
        Dim result As Boolean = False
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
            query = "SELECT param_group_prod FROM " & applicationSettings.DB & ".dbo.mtipe " &
                    "INNER JOIN " & applicationSettings.DB & ".dbo.mdisc ON param_group_prod=type_discgroup " &
                    "WHERE type_partnumber='" & kode & "' AND param_salesorg='" & parameterService.GetValueParamText("POS SLSORG") & "' " &
                    "AND param_salesoffice='" & parameterService.GetValueParamText("POS SALESOFFICE") & "' " &
                    "AND param_discgroup='" & discgroup & "'"

            cm = New SqlCommand
            With cm
                .Connection = cn
                .CommandText = query
            End With

            da = New SqlDataAdapter
            With da
                .SelectCommand = cm
                .Fill(dtTable)
            End With

            If dtTable.Rows.Count > 0 Then
                result = True
            Else
                result = False
            End If
            cn.Close()
            query = ""

        Catch ex As Exception
            cn.Close()
            Throw ex
        End Try

        Return result
    End Function


#End Region

#Region "Display"


#End Region
End Class
