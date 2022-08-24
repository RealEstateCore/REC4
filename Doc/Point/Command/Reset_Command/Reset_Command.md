[Point](../../Point.md) > [Command](../Command.md) > [Reset_Command](.)
# Reset_Command

**Display name:** Reset Command<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Reset_Command;1

---


## Child interfaces
* [Fault_Reset_Command](Fault_Reset_Command.md)
* [Filter_Reset_Command](Filter_Reset_Command.md)
* [Speed_Reset_Command](Speed_Reset_Command.md)

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
