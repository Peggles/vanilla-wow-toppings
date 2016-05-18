pont=0.000
pofft= 0.000
ont = 0.000
offt= 0.000
ons = 0.000
offs= 0.000
offh = 0
onh  = 0
epont=0.000
epofft= 0.000
eont = 0.000
eofft= 0.000
eons = 0.000
eoffs= 0.000
eoffh = 0
eonh  = 0
testvar = 0
if not(abar) then abar={} end
-- cast spell by name hook
preabar_csbn = CastSpellByName
function abar_csbn(pass, onSelf)
	preabar_csbn(pass, onSelf)
	abar_spelldir(pass)
end
CastSpellByName = abar_csbn
--use action hook
preabar_useact = UseAction
function abar_useact(p1,p2,p3)
	preabar_useact(p1,p2,p3)
    local a,b = IsUsableAction(p1)
    if a then
    	if UnitCanAttack("player","target" )then
    		if IsActionInRange(p1) == 1 then
			Abar_Tooltip:ClearLines()
			Abar_Tooltip:SetAction(p1)
    	local spellname = Abar_TooltipTextLeft1:GetText()
    	if spellname then abar_spelldir(spellname) end
    	end
    	end
    end
end
UseAction = abar_useact
--castspell hook
preabar_cassple = CastSpell
function abar_casspl(p1,p2)
	preabar_cassple(p1,p2)
	local spell = GetSpellName(p1,p2)
		abar_spelldir(spell)
end
CastSpell = abar_casspl
function Abar_loaded()
	SlashCmdList["ATKBAR"] = Abar_chat;
	SLASH_ATKBAR1 = "/abar";
	SLASH_ATKBAR2 = "/atkbar";
	if abar.range == nil then
		abar.range=true
	end
	if abar.h2h == nil then
		abar.h2h=true
	end
	if abar.timer == nil then
		abar.timer=true
	end
	Abar_Mhr:SetPoint("LEFT",Abar_Frame,"TOPLEFT",6,-13)
	Abar_Oh:SetPoint("LEFT",Abar_Frame,"TOPLEFT",6,-35)
	Abar_MhrText:SetJustifyH("Left")
	Abar_OhText:SetJustifyH("Left")
	--ebar_VL()
end
function Abar_chat(msg)
	msg = strlower(msg)
	if msg == "fix" then
		Abar_reset()
	elseif msg=="lock" then
		Abar_Frame:Hide()
		--ebar_Frame:Hide()
	elseif msg=="unlock" then
		Abar_Frame:Show()
		--ebar_Frame:Show()
	else
		DEFAULT_CHAT_FRAME:AddMessage('lock - to lock and hide the anchor');
		DEFAULT_CHAT_FRAME:AddMessage('unlock - to unlock and show the anchor');
	end
end
function Abar_selfhit()
ons,offs=UnitAttackSpeed("player");
hd,ld,ohd,old = UnitDamage("player")
hd,ld= hd-math.mod(hd,1),ld-math.mod(ld,1)
if old then
	ohd,old = ohd-math.mod(ohd,1),old-math.mod(old,1)
end	
if offs then
	ont,offt=GetTime(),GetTime()
	if ((math.abs((ont-pont)-ons) <= math.abs((offt-pofft)-offs))and not(onh <= offs/ons)) or offh >= ons/offs then
		if pofft == 0 then pofft=offt end
		pont = ont
		tons = ons
		offh = 0
		onh = onh +1
		ons = ons - math.mod(ons,0.01)
		Abar_Mhrs(tons,"Main "..ons.."s",0,0,1)
	else
		pofft = offt
		offh = offh+1
		onh = 0
		ohd,old = ohd-math.mod(ohd,1),old-math.mod(old,1)
		offs = offs - math.mod(offs,0.01)
		Abar_Ohs(offs,"Off "..offs.."s",0,0,1)
	end
else
	ont=GetTime()
	tons = ons
	ons = ons - math.mod(ons,0.01)
	Abar_Mhrs(tons,"Main "..ons.."s",0,0,1)
end

end
function Abar_reset()
pont=0.000
pofft= 0.000
ont=0.000
offt= 0.000
onid=0
offid=0
end
function Abar_event(event)
  if (event=="CHAT_MSG_COMBAT_SELF_MISSES" or event=="CHAT_MSG_COMBAT_SELF_HITS") and abar.h2h == true then Abar_selfhit() end
  if event=="PLAYER_LEAVE_COMBAT" then Abar_reset() end
  if event == "VARIABLES_LOADED" then Abar_loaded() end
  if event == "CHAT_MSG_SPELL_SELF_DAMAGE" then Abar_spellhit(arg1) end
  if event == "VARIABLES_LOADED" then Abar_loaded() end
end
function Abar_spellhit(arg1)
	a,b,spell=string.find (arg1, "Your (.+) hits")
	if not spell then 	a,b,spell=string.find (arg1, "Your (.+) crits") end
	if not spell then 	a,b,spell=string.find (arg1, "Your (.+) is") end
	if not spell then	a,b,spell=string.find (arg1, "Your (.+) misses") end
		
	
	rs,rhd,rld =UnitRangedDamage("player");
	rhd,rld= rhd-math.mod(rhd,1),rld-math.mod(rld,1)
	if spell == "Auto Shot" and abar.range == true then
		trs=rs
		rs = rs-math.mod(rs,0.01)
		Abar_Mhrs(trs,"Auto Shot "..rs.."s",0,1,0)
	elseif spell == "Shoot" and abar.range==true then
		trs=rs
		rs = rs-math.mod(rs,0.01)
		Abar_Mhrs(trs,"Wand "..ons.."s",.7,.1,1)
	elseif (spell == "Raptor Strike" or spell == "Heroic Strike" or
	spell == "Maul" or spell == "Cleave") and abar.h2h==true then
		hd,ld,ohd,lhd = UnitDamage("player")
		hd,ld= hd-math.mod(hd,1),ld-math.mod(ld,1)
		if pofft == 0 then pofft=offt end
		pont = ont
		tons = ons
		ons = ons - math.mod(ons,0.01)
		Abar_Mhrs(tons,"Main "..ons.."s",0,0,1)
	end
end
function abar_spelldir(spellname)
	if abar.range then
	local a,b,sparse = string.find (spellname, "(.+)%(")
	if sparse then spellname = sparse end
	rs,rhd,rld =UnitRangedDamage("player");
	rhd,rld= rhd-math.mod(rhd,1),rld-math.mod(rld,1)
	if spellname == "Throw" then
		trs=rs
		rs = rs-math.mod(rs,0.01)
		Abar_Mhrs(trs-1,"Thrown "..(rs).."s",1,.5,0)
	elseif spellname == "Shoot" then
		rs =UnitRangedDamage("player")
		trs=rs
		rs = rs-math.mod(rs,0.01)
		Abar_Mhrs(trs-1,"Wand "..(rs).."s",.5,0,1)
	elseif spellname == "Shoot Bow" then
		trs = rs
		rs = rs-math.mod(rs,0.01)
		Abar_Mhrs(trs-1,"Bow "..(rs).."s",1,.5,0)
	elseif spellname == "Shoot Gun" then
		trs = rs
		rs = rs-math.mod(rs,0.01)
		Abar_Mhrs(trs-1,"Gun "..(rs).."s",1,.5,0)
	elseif spellname == "Shoot Crossbow" then
		trs=rs
		rs = rs-math.mod(rs,0.01)
		Abar_Mhrs(trs-1,"X-Bow "..(rs).."s",1,.5,0)
	elseif spellname == "Aimed Shot" then
		trs=rs
		rs = rs-math.mod(rs,0.01)
		Abar_Mhrs(trs-1,"Aiming["..(3).."s]",1,.1,.1) 
	end
	end
	end
	
function Abar_Update()
local ttime = GetTime()
local left = 0.00
tSpark=getglobal(this:GetName().. "Spark")
tText=getglobal(this:GetName().. "Tmr")
if abar.timer==true then
	left = (this.et-GetTime()) - (math.mod((this.et-GetTime()),.1))
--	tText:SetText(this.txt.. "{"..left.."}")
	tText:SetText(left)
	tText:SetPoint("LEFT", this, "LEFT",114, 9);
	tText:Show()
else
        tText:Hide()
end
this:SetValue(ttime)
tSpark:SetPoint("CENTER", this, "LEFT", (ttime-this.st)/(this.et-this.st)*255, 0);
if ttime>=this.et then 
this:Hide() 
tSpark:SetPoint("CENTER", this, "LEFT",195, 0);
end
end
function Abar_Mhrs(bartime,text,r,g,b)
Abar_Mhr:Hide()
Abar_Mhr.txt = text
Abar_Mhr.st = GetTime()
Abar_Mhr.et = GetTime() + bartime
Abar_Mhr:SetStatusBarColor(1,0,0)
Abar_MhrText:SetText(text)
Abar_Mhr:SetMinMaxValues(Abar_Mhr.st,Abar_Mhr.et)
Abar_Mhr:SetValue(Abar_Mhr.st)
Abar_Mhr:Show()
end
function Abar_Ohs(bartime,text,r,g,b)
Abar_Oh:Hide()
Abar_Oh.txt = text
Abar_Oh.st = GetTime()
Abar_Oh.et = GetTime() + bartime
Abar_Oh:SetStatusBarColor(r,g,b)
Abar_OhText:SetText(text)
Abar_Oh:SetMinMaxValues(Abar_Oh.st,Abar_Oh.et)
Abar_Oh:SetValue(Abar_Oh.st)
Abar_Oh:Show()
end
function Abar_Boo(inpt)
if inpt == true then return " ON" else return " OFF" end
end
