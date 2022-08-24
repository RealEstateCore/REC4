[Point](../../Point.md) > [Command](../Command.md) > [Enable_Command](Enable_Command.md) > [Enable_Differential_Enthalpy_Command](#)
# Enable_Differential_Enthalpy_Command

**Display name:** Enable Differential Enthalpy Command<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Enable_Differential_Enthalpy_Command;1

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
