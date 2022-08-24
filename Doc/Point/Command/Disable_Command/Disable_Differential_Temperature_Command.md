[Point](../../Point.md) > [Command](../Command.md) > [Disable_Command](Disable_Command.md) > [Disable_Differential_Temperature_Command](#)
# Disable_Differential_Temperature_Command

**Display name:** Disable Differential Temperature Command<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Disable_Differential_Temperature_Command;1

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
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
