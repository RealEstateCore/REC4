[Point](../../Point.md) > [Command](../Command.md) > [On_Off_Command](.)
# On_Off_Command

**Display name:** On Off Command<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:On_Off_Command;1

---


## Child interfaces
* [Lead_On_Off_Command](Lead_On_Off_Command.md)
* [Off_Command](Off_Command.md)
* [On_Command](On_Command.md)
* [Start_Stop_Command](Start_Stop_Command.md)
* [Steam_On_Off_Command](Steam_On_Off_Command.md)

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
