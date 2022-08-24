[Point](../../Point.md) > [Command](../Command.md) > [Position_Command](#)
# Position_Command

**Display name:** Position Command<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Position_Command;1

---


## Child interfaces
* [Damper_Position_Command](Damper_Position_Command.md)
* [Valve_Position_Command](../Valve_Command/Valve_Position_Command.md)

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
