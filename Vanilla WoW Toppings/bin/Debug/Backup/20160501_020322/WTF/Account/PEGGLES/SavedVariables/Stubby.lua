
StubbyConfig = {
	["addinfo"] = {
		["EnhTooltip"] = "EnhTooltip|Used to display enhanced tooltips under the original tooltip or in the original tooltip, contains hooking functions for almost all major in game item tooltips [3.9.0.1030] This AddOn is licenced under the GNU GPL, see GPL.txt for details.",
		["Informant"] = "Informant|Displays detailed item information in tooltips, and can produce item reports by binding an information window to a keypress [3.9.0.1000] This AddOn is licenced under the GNU GPL, see GPL.txt for details.",
	},
	["inspected"] = {
		["EnhTooltip"] = true,
		["Informant"] = true,
	},
	["configs"] = {
		["informant"] = {
			["loadtype"] = "always",
		},
	},
	["boots"] = {
		["informant"] = {
			["commandhandler"] = "		local function cmdHandler(msg)\n			local i,j, cmd, param = string.find(string.lower(msg), \"^([^ ]+) (.+)$\")\n			if (not cmd) then cmd = string.lower(msg) end\n			if (not cmd) then cmd = \"\" end\n			if (not param) then param = \"\" end\n			if (cmd == \"load\") then\n				if (param == \"\") then\n					Stubby.Print(\"Manually loading Informant...\")\n					LoadAddOn(\"Informant\")\n				elseif (param == \"always\") then\n					Stubby.Print(\"Setting Informant to always load for this character\")\n					Stubby.SetConfig(\"Informant\", \"LoadType\", param)\n					LoadAddOn(\"Informant\")\n				elseif (param == \"never\") then\n					Stubby.Print(\"Setting Informant to never load automatically for this character (you may still load manually)\")\n					Stubby.SetConfig(\"Informant\", \"LoadType\", param)\n				else\n					Stubby.Print(\"Your command was not understood\")\n				end\n			else\n				Stubby.Print(\"Informant is currently not loaded.\")\n				Stubby.Print(\"  You may load it now by typing |cffffffff/informant load|r\")\n				Stubby.Print(\"  You may also set your loading preferences for this character by using the following commands:\")\n				Stubby.Print(\"  |cffffffff/informant load always|r - Informant will always load for this character\")\n				Stubby.Print(\"  |cffffffff/informant load never|r - Informant will never load automatically for this character (you may still load it manually)\")\n			end\n		end\n		SLASH_INFORMANT1 = \"/informant\"\n		SLASH_INFORMANT2 = \"/inform\"\n		SLASH_INFORMANT3 = \"/info\"\n		SLASH_INFORMANT4 = \"/inf\"\n		SlashCmdList[\"INFORMANT\"] = cmdHandler\n	",
			["triggers"] = "		local loadType = Stubby.GetConfig(\"Informant\", \"LoadType\")\n		if (loadType == \"always\") then\n			LoadAddOn(\"Informant\")\n		else\n			Stubby.Print(\"Informant is not loaded. Type /informant for more info.\");\n		end\n	",
		},
	},
}
